using MySql.Data.MySqlClient;
using Servico.model;
using Servico;

namespace Servico
{
    public class Db
    {
        private readonly MySqlConnection _con;
        private MySqlCommand? _cdm;
        private MySqlDataReader _reader;

        public Db()
        {
            _con = new MySqlConnection("Server=127.0.0.1;Database=carros;Uid=root;Pwd=;SslMode=none");
        }

        public List<CarroTO> GetCarros()
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "SELECT * FROM carros";
            _reader = _cdm.ExecuteReader();

            var listaCarro = new List<CarroTO>();

            while (_reader.Read())
            {
                var Carro = new CarroTO()
                {
                    Id = int.Parse(_reader["id"].ToString()!),
                    Nome = _reader["nome"].ToString()!,
                    Fabricante = _reader["nome"].ToString()!,
                    Marca = _reader["nome"].ToString()!,
                    Modelo = _reader["nome"].ToString()!,
                    Ano = int.Parse(_reader["id"].ToString()!),

                };
                listaCarro.Add(Carro);
            }
            _con.Close();

            return listaCarro;

        }

        public void AddCarro(CarroTO carro)
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "INSERT INTO carro (Nome, Fabricante, Marca, Modelo, Ano) VALUE (?nome, ?fabricante, ?marca, ?modelo, ?ano)";
            _cdm.Parameters.Add("?nome", MySqlDbType.VarChar).Value = carro.Nome;
            _cdm.Parameters.Add("?fabricante", MySqlDbType.VarChar).Value = carro.Fabricante;
            _cdm.Parameters.Add("?marca", MySqlDbType.VarChar).Value = carro.Marca;
            _cdm.Parameters.Add("?modelo", MySqlDbType.VarChar).Value = carro.Modelo;
            _cdm.Parameters.Add("?ano", MySqlDbType.Int64).Value = carro.Ano;


            if (_cdm.ExecuteNonQuery() >= 1)
            {
                //true
            }
            else
            {
                //false
            }

            _con.Close();

        }

        public void UpdateCarro(CarroTO carro)
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "UPDATE carro SET (Nome, Fabricante, Marca, Modelo, Ano) VALUE (?nome, ?fabricante, ?marca, ?modelo, ?ano) WHERE Id = (?id)";
            _cdm.Parameters.Add("?nome", MySqlDbType.VarChar).Value = carro.Nome;
            _cdm.Parameters.Add("?fabricante", MySqlDbType.VarChar).Value = carro.Fabricante;
            _cdm.Parameters.Add("?marca", MySqlDbType.VarChar).Value = carro.Marca;
            _cdm.Parameters.Add("?modelo", MySqlDbType.VarChar).Value = carro.Modelo;
            _cdm.Parameters.Add("?ano", MySqlDbType.Int64).Value = carro.Ano;
            _cdm.Parameters.Add("?id", MySqlDbType.Int64).Value = carro.Id;

            if (_cdm.ExecuteNonQuery() >= 1)
            {
                //TRUE
            }
            else
            {
                //false
            }
        }

        public CarroTO GetCarroById(int id)
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "SELECT * FROM carro WHERE id = ?id";
            _cdm.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
            _reader = _cdm.ExecuteReader();

            var carro = new CarroTO();

            _reader.Read();
            carro.Id = int.Parse(_reader["id"].ToString()!);
            carro.Nome = _reader["nome"].ToString()!;
            carro.Fabricante = _reader["fabricante"].ToString()!;
            carro.Marca = _reader["marca"].ToString()!;
            carro.Modelo = _reader["modelo"].ToString()!;
            carro.Ano = int.Parse(_reader["ano"].ToString()!);

            _con.Close();

            return carro;
        }

        public void DeletarCarro(int id)
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "DELETE FROM carros WHERE Id = ?id";
            _cdm.Parameters.Add("?id", MySqlDbType.Int64).Value = id;

            if (_cdm.ExecuteNonQuery() >= 1)
            {
                //true
            }
            else
            {
                //false
            }
            _con.Close();
        }
    }
}