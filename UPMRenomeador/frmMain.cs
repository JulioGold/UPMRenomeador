using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UPMRenomeador
{
    public partial class frmMain : Form
    {
        DataSet ds = new DataSet();
        DataTable listaArquivos = new DataTable("listaArquivos");

        public frmMain()
        {
            InitializeComponent();

            listaArquivos.Columns.Add("Marcado");
            listaArquivos.Columns.Add("ArquivoOriginal");
            listaArquivos.Columns.Add("ArquivoModificado");
            listaArquivos.Columns.Add("CaminhoCompleto");

            comboBox1.SelectedIndex = 0;
            cboRetirarEspacos.SelectedIndex = 0;
        }

        #region Tratamento de strings

        /// <summary>
        /// Método que faz a substituição de uma palavra por outra
        /// </summary>
        /// <param name="original">Texto onde será feita a substituição.</param>
        /// <param name="procurar">Palavra que deve ser procurada.</param>
        /// <param name="substituir">Palavra que será colocada no lugar da palavra à ser procurada.</param>
        /// <returns></returns>
        private string Substitui(string original, string procurar, string substituir)
        {
            return original.Replace(procurar, substituir);
        }

        /// <summary>
        /// Método que deixa a letra inicial de cada palavra em maiúscula.
        /// </summary>
        /// <param name="original">Texto a ser modificado.</param>
        /// <returns></returns>
        private string IniciaisMaiusculas(string original)
        {
            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            return cultureinfo.TextInfo.ToTitleCase(original);
        }

        /// <summary>
        /// Método que faz o tratamento do texto onde será inserido o numerador
        /// a tag é substituída pelo valor do numerador.
        /// </summary>
        /// <param name="texto">Texto que contém a tag à ser tratada.</param>
        /// <param name="numerador">Valor que deve ser inserido no local da tag do numerador por número.</param>
        /// <returns></returns>
        private string TrataNumerador(string texto, int numerador)
        {
            // Será a string retornada já com o valor do numerador
            string textoEnumerado = "";

            //Posição inicial para definir onde inicia a TAG de numerador por número
            int numeradorPosNUMEROIni = texto.IndexOf("%numero");
            // Posição final a partir da posição inicial antes encontrada, para definir onde termina a TAG de numerador por número
            int numeradorPosNUMEROFin = texto.IndexOf("%", numeradorPosNUMEROIni + 1);

            // Só vou fazer algo se encontrei o início e final da TAG %numero%
            if (numeradorPosNUMEROIni >= 0 && numeradorPosNUMEROFin > numeradorPosNUMEROIni)
            {
                // Verifica se o próximo caracter da sequência %numero for um % então é porque terminou a TAG
                if (BuscaCaracterPorPosicao(texto, numeradorPosNUMEROIni + 7) == '%')
                {
                    // Não deve fazer mais nada, afinal já terminou a TAG
                }
                // Se não era um % então é porque quer preencher com algo ou preencheu alguma besteira antes de fechar a TAG
                else
                {
                    // ESPERA deixada para adicionar a funcionalidade de preencher com números até um tamanho definido
                }

                //Terminando o numerador por número, vou retirar a TAG e adicionar o numerador no local
                textoEnumerado = texto.Remove(numeradorPosNUMEROIni, 8);
                textoEnumerado = textoEnumerado.Insert(numeradorPosNUMEROIni, numerador.ToString().Trim());
            }


            //Posição inicial para definir onde inicia a TAG de numerador por letra
            int numeradorPosLETRAIni = texto.IndexOf("%letra");
            // Posição final a partir da posição inicial antes encontrada, para definir onde termina a TAG de numerador por letra
            int numeradorPosLETRAFin = texto.IndexOf("%", numeradorPosLETRAIni + 1);

            // Só vou fazer algo se encontrei o início e final da TAG %letra%
            if (numeradorPosLETRAIni >= 0 && numeradorPosLETRAFin > numeradorPosLETRAIni)
            {
                string numeradorLetra = SubstituiNumero(numerador);

                // Verifica se o próximo caracter da sequência %numero for um % então é porque terminou a TAG
                if (BuscaCaracterPorPosicao(texto, numeradorPosNUMEROIni + 6) == '%')
                {
                    // Não deve fazer mais nada, afinal já terminou a TAG
                }
                // Se não era um % então é porque quer preencher com algo ou preencheu alguma besteira antes de fechar a TAG
                else
                {
                    // ESPERA deixada para adicionar a funcionalidade de preencher com números até um tamanho definido
                }

                //Terminando o numerador por número, vou retirar a TAG e adicionar o numerador no local
                textoEnumerado = texto.Remove(numeradorPosLETRAIni, 7);
                textoEnumerado = textoEnumerado.Insert(numeradorPosLETRAIni, numeradorLetra);
            }

            return textoEnumerado;
        }

        /// <summary>
        /// Método que busca um caracter de uma determinada posição desejada de uma string.
        /// </summary>
        /// <param name="texto">String de onde o caracter será pego.</param>
        /// <param name="posicao">Posição que deseja pegar o caracter.</param>
        /// <returns></returns>
        private char BuscaCaracterPorPosicao(string texto, int posicao)
        {
            char[] textoCaracteres = texto.ToCharArray();
            char caracterRetorno = '\0'; //Inicializa com nulo

            for (int i = 0; i <= posicao; i++)
            {
                caracterRetorno = textoCaracteres[i];
            }
            return caracterRetorno;
        }


        /// <summary>
        /// Substitui número por uma letra, EX: 0 por A, 1 por B, 2 por C...
        /// </summary>
        /// <param name="numero">Número a ser substituído.</param>
        /// <returns></returns>
        private string SubstituiNumero(int numero)
        {
            string numeroConv = numero.ToString().Trim();

            numeroConv = numeroConv.Replace("0", "A");
            numeroConv = numeroConv.Replace("1", "B");
            numeroConv = numeroConv.Replace("2", "C");
            numeroConv = numeroConv.Replace("3", "D");
            numeroConv = numeroConv.Replace("4", "E");
            numeroConv = numeroConv.Replace("5", "F");
            numeroConv = numeroConv.Replace("6", "G");
            numeroConv = numeroConv.Replace("7", "H");
            numeroConv = numeroConv.Replace("8", "I");
            numeroConv = numeroConv.Replace("9", "I");
            return numeroConv;
        }

        /// <remarks>
        /// GetCharIndexFromPosition is missing one caret position, as there is one extra caret
        /// position than there are characters (an extra one at the end).
        /// </remarks>
        private int GetCaretIndexFromPoint(System.Windows.Forms.TextBox box, int x, int y)
        {
            Point realPoint = box.PointToClient(new Point(x, y));
            int index = box.GetCharIndexFromPosition(realPoint);
            if (index == box.Text.Length - 1)
            {
                Point caretPoint = box.GetPositionFromCharIndex(index);
                if (realPoint.X > caretPoint.X)
                {
                    index += 1;
                }
            }
            return index;
        }

        /// <summary>
        /// Retira os caracteres especiais que não podem ser utilizados em nomes de arquivos.
        /// </summary>
        /// <param name="texto">String que será tratada.</param>
        /// <returns></returns>
        private string TiraCaracteresEspeciais(string texto)
        {
            texto = texto.Replace(@"\", "");
            texto = texto.Replace("/", "");
            texto = texto.Replace(":", "");
            texto = texto.Replace("*", "");
            texto = texto.Replace("?", "");
            texto = texto.Replace("\"", "");
            texto = texto.Replace("<", "");
            texto = texto.Replace(">", "");
            texto = texto.Replace("|", "");

            return texto;
        }
        #endregion

        #region Eventos de Drag And Drop

        private void lblTAGnumero_MouseDown_1(object sender, MouseEventArgs e)
        {
            lblTAGnumero.DoDragDrop(lblTAGnumero.Text, DragDropEffects.Copy);
        }

        private void lblTAGletra_MouseDown_1(object sender, MouseEventArgs e)
        {
            lblTAGnumero.DoDragDrop(lblTAGletra.Text, DragDropEffects.Copy);
        }

        private void txtInserir_DragEnter_1(object sender, DragEventArgs e)
        {
            // Verifica se o tipo de dado que está sendo arrastado é texto, se for aceita como cópia, senão não aceita
            if (e.Data.GetDataPresent(DataFormats.UnicodeText))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtInserir_DragOver_1(object sender, DragEventArgs e)
        {
            // Vai movendo o cursor do teclado conforme passa o mouse
            txtInserir.SelectionStart = GetCaretIndexFromPoint(txtInserir, e.X, e.Y);
            // O tamanho da seleção é zero
            txtInserir.SelectionLength = 0;
            // Não esquecer de dar o foco no textbox para deixar o cursor do teclado visível
            txtInserir.Focus();
        }

        private void txtInserir_DragDrop_1(object sender, DragEventArgs e)
        {
            // Quando soltar o clique, inserir o texto na posição que estava o mouse
            txtInserir.Text = txtInserir.Text.Insert(txtInserir.SelectionStart, e.Data.GetData(DataFormats.UnicodeText).ToString());
        }

        private void txtPor_DragOver_1(object sender, DragEventArgs e)
        {
            // Vai movendo o cursor do teclado conforme passa o mouse
            txtPor.SelectionStart = GetCaretIndexFromPoint(txtPor, e.X, e.Y);
            // O tamanho da seleção é zero
            txtPor.SelectionLength = 0;
            // Não esquecer de dar o foco no textbox para deixar o cursor do teclado visível
            txtPor.Focus();
        }

        private void txtPor_DragEnter_1(object sender, DragEventArgs e)
        {
            // Verifica se o tipo de dado que está sendo arrastado é texto, se for aceita como cópia, senão não aceita
            if (e.Data.GetDataPresent(DataFormats.UnicodeText))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtPor_DragDrop_1(object sender, DragEventArgs e)
        {
            // Quando soltar o clique, inserir o texto na posição que estava o mouse
            txtPor.Text = txtPor.Text.Insert(txtPor.SelectionStart, e.Data.GetData(DataFormats.UnicodeText).ToString());
        }

        #endregion

        private void VerificaInconsistencias()
        {

        }

        /// <summary>
        /// Renomeia os arquivos da lista.
        /// </summary>
        private void RenomeiaLista()
        {
            for (int i = 0; i < listaArquivos.Rows.Count; i++)
            {
                // Mesmo que não esteja marcado, vou retirar os caracteres especiais que não devem ser utilizados em nomes de arquivos.
                listaArquivos.Rows[i]["ArquivoModificado"] = TiraCaracteresEspeciais(listaArquivos.Rows[i]["ArquivoModificado"].ToString());

                // Se estiver marcado então pode aplicar as modificações
                if (listaArquivos.Rows[i]["Marcado"].ToString().Trim() != "")
                {
                    string caminhoCompleto = listaArquivos.Rows[i]["CaminhoCompleto"].ToString().Trim();
                    string caminhoCompletoNovo = System.IO.Path.GetDirectoryName(listaArquivos.Rows[i]["CaminhoCompleto"].ToString().Trim()) + Path.DirectorySeparatorChar + listaArquivos.Rows[i]["ArquivoModificado"].ToString().Trim();

                    if (File.Exists(caminhoCompleto) && !File.Exists(caminhoCompletoNovo))
                    {
                        System.IO.File.Move(caminhoCompleto, caminhoCompletoNovo);    
                    }

                    
                }
            }

            MessageBox.Show("Processo terminado!");
        }

        private void LerPasta(string pathPasta)
        {
            //Se o path passado existir continua
            if (Directory.Exists(pathPasta))
            {
                DirectoryInfo pastas = new DirectoryInfo(pathPasta);

                FileInfo[] arquivosLista = pastas.GetFiles();

                listaArquivos.Clear();

                object[] ValoresColunas = new object[4];

                foreach (FileInfo arquivo in arquivosLista)
                {
                    ValoresColunas[0] = true;
                    ValoresColunas[1] = arquivo.Name;
                    ValoresColunas[2] = arquivo.Name;
                    ValoresColunas[3] = arquivo.FullName;
                    listaArquivos.Rows.Add(ValoresColunas);
                }

                ds.Tables.Clear();
                ds.Tables.Add(listaArquivos);

                dataGridView1.DataSource = ds.Tables["listaArquivos"];
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LerPasta(textBox1.Text.Trim());
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            LerPasta(textBox1.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caixaSelecaoPasta = new FolderBrowserDialog();

            caixaSelecaoPasta.ShowDialog();

            if (caixaSelecaoPasta.SelectedPath.Trim() != "")
            {
                textBox1.Text = caixaSelecaoPasta.SelectedPath;

                LerPasta(caixaSelecaoPasta.SelectedPath);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                statusStrip1.Items[0].Text = listaArquivos.Rows[dataGridView1.CurrentRow.Index]["CaminhoCompleto"].ToString();
            }
            else
            {
                statusStrip1.Items[0].Text = "";
            }
        }

        private void btnAplicarNosArquivos_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Você realmente quer aplicar a modificação aos arquivos?", "Não faça besteira!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                // Chama rotina que renomeia os arquivos
                RenomeiaLista();
            }
        }

        private void setUpNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frmSobre = new AboutBox();
            frmSobre.ShowDialog();
        }

        private void fecharEssaCoisaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dotClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dotclass.com.br");
        }

        private void btnAplicarNaLista_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaArquivos.Rows.Count; i++)
            {

                // Mesmo que não esteja marcado, vou retirar os caracteres especiais que não devem ser utilizados em nomes de arquivos.
                listaArquivos.Rows[i]["ArquivoModificado"] = TiraCaracteresEspeciais(listaArquivos.Rows[i]["ArquivoModificado"].ToString());

                // Se estiver marcado então pode aplicar as modificações
                if (listaArquivos.Rows[i]["Marcado"].ToString().Trim() != "")
                {

                    // Se foi preenchido algo nos campos Substituir e Por então substitui a palavra desejada
                    if (txtDe.Text.Length > 0 && txtPor.Text.Length > 0)
                    {
                        string textoPor = txtPor.Text;

                        //Se achar o início da TAG de numerador por número, vou mandar tratar o numerador
                        if (txtPor.Text.IndexOf("%numero") >= 0)
                        {
                            textoPor = TrataNumerador(txtPor.Text, i); // Mando fazer o tratamento do numerador que já retorna a string pronta
                        }

                        //Se achar o início da TAG de numerador por letra, vou mandar tratar o numerador
                        if (txtPor.Text.IndexOf("%letra") >= 0)
                        {
                            textoPor = TrataNumerador(textoPor, i); // Mando fazer o tratamento do numerador que já retorna a string pronta
                        }

                        listaArquivos.Rows[i]["ArquivoModificado"] = Substitui(listaArquivos.Rows[i]["ArquivoModificado"].ToString(), txtDe.Text, textoPor);
                    }

                    // Inserir texto em determinada posição (Trim >= 1 para poder inserir espaços se desejado)
                    if (txtInserir.Text.Trim().Length + 1 >= 1)
                    {
                        string textoInserir = txtInserir.Text;

                        if (txtInserir.Text.IndexOf("%numero") >= 0)
                        {
                            textoInserir = TrataNumerador(txtInserir.Text, i);
                        }

                        if (txtInserir.Text.IndexOf("%letra") >= 0)
                        {
                            textoInserir = TrataNumerador(textoInserir, i);
                        }

                        // String com 240 espaços
                        string espacos = "                                                                                                                                                                                                                                                ";

                        // Controle para não inserir em uma posição inexistente, se não existe aquela posição, crio tudo com espaços
                        if (listaArquivos.Rows[i]["ArquivoModificado"].ToString().Length - 1 <= nudInserirPos.Value)
                        {
                            espacos = espacos.Insert(0, listaArquivos.Rows[i]["ArquivoModificado"].ToString());

                            listaArquivos.Rows[i]["ArquivoModificado"] = espacos.Substring(0, 241);
                        }

                        string texto = listaArquivos.Rows[i]["ArquivoModificado"].ToString().Insert((int)nudInserirPos.Value, textoInserir);

                        listaArquivos.Rows[i]["ArquivoModificado"] = texto;
                    }

                    // Se escolheu retirar espaços da Esquerda
                    if (cboRetirarEspacos.SelectedIndex == 1)
                    {
                        listaArquivos.Rows[i]["ArquivoModificado"] = listaArquivos.Rows[i]["ArquivoModificado"].ToString().TrimStart();
                    }
                    // Se escolheu retirar espaços da Direita
                    else if (cboRetirarEspacos.SelectedIndex == 2)
                    {
                        listaArquivos.Rows[i]["ArquivoModificado"] = listaArquivos.Rows[i]["ArquivoModificado"].ToString().TrimEnd();
                    }
                    // Se escolheu retirar espaços dos dois lados
                    else if (cboRetirarEspacos.SelectedIndex == 3)
                    {
                        listaArquivos.Rows[i]["ArquivoModificado"] = IniciaisMaiusculas(listaArquivos.Rows[i]["ArquivoModificado"].ToString().Trim());
                    }

                    // Se escolheu Maiúsculas
                    if (comboBox1.SelectedIndex == 1)
                    {
                        listaArquivos.Rows[i]["ArquivoModificado"] = listaArquivos.Rows[i]["ArquivoModificado"].ToString().ToUpper();
                    }
                    // Se escolheu Minúsculas
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        listaArquivos.Rows[i]["ArquivoModificado"] = listaArquivos.Rows[i]["ArquivoModificado"].ToString().ToLower();
                    }
                    // Se escolheu Iniciais em maiúsculas
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        listaArquivos.Rows[i]["ArquivoModificado"] = IniciaisMaiusculas(listaArquivos.Rows[i]["ArquivoModificado"].ToString());
                    }
                }
            }
        }
    }
}
