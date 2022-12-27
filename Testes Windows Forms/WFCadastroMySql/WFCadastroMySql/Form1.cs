using System;
using System.Drawing.Text;
using System.Security.Policy;
using MySql.Data.MySqlClient;

namespace WFCadastroMySql
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;

        //Criar fonte de dados que o mysqlconnection pede
        private string data_source = "datasource=localhost;username=root;password=;database=db_agenda";

        private int ?id_contato_selecionado = null;

        public Form1()
        {
            InitializeComponent();

            lst_contatos.View = View.Details;
            lst_contatos.LabelEdit = true;
            lst_contatos.AllowColumnReorder= true;  
            lst_contatos.FullRowSelect = true;
            lst_contatos.GridLines= true;   

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregar();

            //carregar_lista();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                
                cmd.Connection = Conexao;

                if (id_contato_selecionado == null)
                {
                    //Insert
                    cmd.CommandText = "INSERT INTO contato " +
                   "VALUES" +
                   "(NULL, @nome, @email, @telefone) ";



                    cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@telefone", txt_Telefone.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Prepare();

                    MessageBox.Show("Contato inserido!","Salvo", MessageBoxButtons.OK);
                }
                else
                {
                    //Update
                    cmd.CommandText = "UPDATE contato " +
                                       "SET nome=@nome, email=@email, telefone=@telefone " +
                                       "WHERE id=@id";



                    cmd.Parameters.AddWithValue("@nome", txt_Nome.Text);
                    cmd.Parameters.AddWithValue("@email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@telefone", txt_Telefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);
                    cmd.ExecuteNonQuery();
                    cmd.Prepare();

                    MessageBox.Show("Contato atualizado!", "Sucesso", MessageBoxButtons.OK);
                }

                id_contato_selecionado = null;

                txt_Nome.Text = String.Empty;
                txt_Email.Text = "";
                txt_Telefone.Text = "";

                carregar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            finally
            {
                Conexao.Close();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            try
            {

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q ";

                cmd.Parameters.AddWithValue("@q", "%" + txt_buscar.Text + "%");

                cmd.ExecuteNonQuery();
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    lst_contatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " de busca: " + ex.Message,
        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                Conexao.Close();
            }
        }
        private void carregar()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM contato ORDER BY id ASC ";

                MySqlDataReader reader = cmd.ExecuteReader();
               
                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    lst_contatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista.");
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conexao.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lst_contatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lst_contatos.SelectedItems;

            foreach(ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txt_Nome.Text = item.SubItems[1].Text;
                txt_Email.Text = item.SubItems[2].Text;
                txt_Telefone.Text = item.SubItems[3].Text;

                btn_Excluir.Visible = true;
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            id_contato_selecionado = null;

            txt_Nome.Text = String.Empty;
            txt_Email.Text = "";
            txt_Telefone.Text = "";

            txt_Nome.Focus();

            btn_Excluir.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluir();      
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            excluir();
        }
        private void excluir () 
        {
            try
            {
                DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir o contato?",
                                                     "Excluir",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (conf == DialogResult.Yes)
                {
                    Conexao = new MySqlConnection(data_source);

                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM contato WHERE id=@id";

                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);
                    cmd.ExecuteNonQuery();
                    cmd.Prepare();

                    //Excluir
                    MessageBox.Show("Contato excluido!", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    txt_Nome.Text = String.Empty;
                    txt_Email.Text = "";
                    txt_Telefone.Text = "";

                    txt_Nome.Focus();
                    carregar();
                    btn_Excluir.Visible = false;
                };
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deseja excluir o " + id_contato_selecionado + "?");
            }
            finally
            {
                Conexao.Close();
            }

        }

    }
    }