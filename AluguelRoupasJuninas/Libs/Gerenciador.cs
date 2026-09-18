using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelRoupasJuninas
{
    public class Gerenciador
    {
        public static Roupa Roupa = new Roupa();
        public static List<Roupa> ListRoupas = new List<Roupa>();
        public static List<Aluguel> ListAlugueis = new List<Aluguel>();
        public static void InicializarBanco()
        {
            try
            {
                if (!File.Exists("roupas.db"))
                    SQLiteConnection.CreateFile("roupas.db");

                CriarTabRopas();
                CriarTabAlugueis();
            }
            catch
            {
                MessageBox.Show("Erro ao inicializar o banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CriarTabRopas()
        {
            try
            {
                var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");

                conn.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS TB_Roupas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT,
                Tamanho TEXT,
                Categoria TEXT,
                CaminhoImagem TEXT
                )";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar tabela de roupas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private  static void CriarTabAlugueis()
        {
            try
            {
                var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS TB_Aluguel (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                RoupaId INTEGER,
                Cliente TEXT,
                DataAluguel DATE,
                DataDevolucao DATE,
                Valor DOUBLE,
                FormaPagamento TEXT,
                Devolucao BOOLEAN DEFAULT 0,
                FOREIGN KEY (RoupaId) REFERENCES TB_Roupas(Id)
                )";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar tabela de alugueis: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SalvarRoupa(Roupa roupa)
        {
            try
            {
                var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
                conn.Open();
                string sql = "INSERT INTO TB_Roupas (Nome, Tamanho, Categoria, CaminhoImagem) VALUES (@nome, @tamanho, @categoria, @img)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", roupa.Nome);
                cmd.Parameters.AddWithValue("@tamanho", roupa.Tamanho);
                cmd.Parameters.AddWithValue("@categoria", roupa.Categoria);
                cmd.Parameters.AddWithValue("@img", roupa.CaminhoImagem);
                cmd.ExecuteNonQuery();
                conn.Close();
                CarregarRoupas();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao salvar. {e.Message}");
            }
        }
        public static void CarregarRoupas()
        {
            ListRoupas.Clear();
            var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
            conn.Open();
            string sql = "SELECT * FROM TB_Roupas";
            var cmd = new SQLiteCommand(sql, conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListRoupas.Add(new Roupa
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Tamanho = reader["Tamanho"].ToString(),
                    Categoria = reader["Categoria"].ToString(),
                    CaminhoImagem = reader["CaminhoImagem"].ToString()
                });

            }
        }

        public static void CarregarAlugueis(int roupaId)
        {
            try
            {
                ListAlugueis.Clear();
                var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
                conn.Open();
                string sql = "SELECT * FROM TB_Aluguel";
                var cmd = new SQLiteCommand(sql, conn);

                if (roupaId > 0)
                {
                    sql += " WHERE RoupaId = @roupaId";
                    cmd.Parameters.AddWithValue("@roupaId", roupaId);;
                }
              
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListAlugueis.Add(new Aluguel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        IdRoupa = Convert.ToInt32(reader["RoupaId"]),
                        DataAluguel = Convert.ToDateTime(reader["DataAluguel"]),
                        DataDevolucao = Convert.ToDateTime(reader["DataDevolucao"]),
                        Cliente = reader["Cliente"].ToString(),
                        Valor = Convert.ToDouble(reader["Valor"]),
                        FormaPagamento = reader["FormaPagamento"].ToString(),
                        Devolucao = Convert.ToBoolean(reader["Devolucao"])
                    });
                }

            }
            catch(Exception e)
            {
                MessageBox.Show($"Não foi possivel carregar a lista! {e.Message}");
            }
        }
        public static void CarregarAlugueis()
        {
            try
            {
                ListAlugueis.Clear();
                var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
                conn.Open();
                string sql = "SELECT * FROM TB_Aluguel";
                var cmd = new SQLiteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListAlugueis.Add(new Aluguel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        IdRoupa = Convert.ToInt32(reader["RoupaId"]),
                        DataAluguel = Convert.ToDateTime(reader["DataAluguel"]),
                        DataDevolucao = Convert.ToDateTime(reader["DataDevolucao"]),
                        Cliente = reader["Cliente"].ToString(),
                        Valor = Convert.ToDouble(reader["Valor"]),
                        FormaPagamento = reader["FormaPagamento"].ToString(),
                        Devolucao = Convert.ToBoolean(reader["Devolucao"])

                    });
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar a lista de alugueis! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RemoverRoupa(int id)
        {
            var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
            conn.Open();
            string sql = "DELETE FROM TB_Roupas WHERE Id = @id";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void RemoverAluguel(int id)
        {

            var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
            conn.Open();
            string sql = "DELETE FROM TB_Aluguel WHERE Id = @id";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void AtualizarRoupaNoBanco(Roupa roupa)
        {
            try
            {
                var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
                conn.Open();
                string sql = "UPDATE TB_Roupas SET Nome = @nome, Tamanho = @tamanho, Categoria = @categoria, CaminhoImagem = @img WHERE Id = @id";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", roupa.Nome);
                cmd.Parameters.AddWithValue("@tamanho", roupa.Tamanho);
                cmd.Parameters.AddWithValue("@categoria", roupa.Categoria);
                cmd.Parameters.AddWithValue("@img", roupa.CaminhoImagem);
                cmd.Parameters.AddWithValue("@id", roupa.Id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao atualizar roupa no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarAluguel(Aluguel aluguel)
        {
            try
            {
                var conn = new SQLiteConnection("Data Source=roupas.db;Version=3;");
                conn.Open();
                string sql = "UPDATE TB_Aluguel SET Devolucao = @devolucao WHERE Id = @id";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", aluguel.Id);
                cmd.Parameters.AddWithValue("@devolucao", aluguel.Devolucao);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlugarRoupa(int roupaId, DateTime data, DateTime data2, double valor, string formaPagamento, string cliente)
        {
            bool devolucao = false;
            try
            {
                var conexao = new SQLiteConnection("Data Source=roupas.db");
                conexao.Open();
                string sql = "INSERT INTO TB_Aluguel (RoupaId, DataAluguel, DataDevolucao, Valor, FormaPagamento, Cliente, Devolucao) VALUES (@roupaId, @data, @data2, @valor, @formaPagamento, @cliente, @devolucao)";
                var cmd = new SQLiteCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@roupaId", roupaId);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@data2", data2);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@formaPagamento", formaPagamento);
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@devolucao", devolucao);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alugar roupa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void NotificarAlugueis()
        {
            DateTime data = DateTime.Now;
            CarregarAlugueis();

            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Exclamation,
                Visible = true,
                BalloonTipTitle = "Dia de devolução.",
                BalloonTipIcon = ToolTipIcon.Info,                
            };

            foreach (var aluguel in ListAlugueis)
            {
                if (aluguel.DataDevolucao.Date == data.Date)
                {
                    foreach(var roupa in ListRoupas)
                    {
                        if(roupa.Id == aluguel.IdRoupa)
                        {
                            notifyIcon.BalloonTipText = $"Roupa: {roupa.Nome}\nCliente: {aluguel.Cliente}";
                            notifyIcon.ShowBalloonTip(3000);
                            return;
                        }
                    }
                }
            }


        }

    }

}
