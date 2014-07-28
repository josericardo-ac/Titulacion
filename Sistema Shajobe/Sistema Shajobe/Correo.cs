using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Librerias de Windows Forms
using System.Windows.Forms;
//Librerias para envio de correo
using System.Net.Mail;
using System.Net;
//Librerias Agregadas 
using System.Data.OleDb;//Establece el tipo de conexion a la base de datos
using System.Configuration;//Establecemos comunicacion con la libreria de configuracion para poder hacer uso del App.Config
using Sistema_Shajobe.Properties;
using System.Data;//Nos permite tener acceso y control sobre las propiedades del proyecto en este caso la direccion del appconfig y entre otros

namespace Sistema_Shajobe
{
    class Correo
    {
        //DATOS PARA ARMAR EL CORREO
        private string _De;
        private string _Contraseña;
        private string _Para;
        private int _Servidor;
        private void Recibe_Datos(string Para, int Servidor)
        {
            this._Para = Para;
            this._Servidor = Servidor;
            //OBTENGO LOS DATOS DEL SISTEMA
            #region Remitente
            Obtiene_Datos();
            #endregion
        }
        private void Envia_Datos()
        {
            MailMessage msg = new MailMessage();
            //Quien escribe al correo
            msg.From = new MailAddress(_De);
            //A quien va dirigido
            msg.To.Add(new MailAddress(_Para));
            //Asunto
            msg.Subject = "MENSAJE DE SHAJOBE";
            //Contenido del correo
            msg.Body = "PRUEBA DE CORREO";


            //INFORMACION DEL SERVIDOR
            SmtpClient ClienteSmtp = new SmtpClient();//EN CASO DE QUE SEA SERVIDOR LOCAL SE USA ESTA INSTRUCCION "WIN02" EN CASO DE QUE NO SE USAN LOS PARAMETROS DE ABAJO
            ClienteSmtp.Credentials = new NetworkCredential(_De, _Contraseña);
            if (_Servidor == 1)
            {
                //"hotmail.com"
                ClienteSmtp.Host = "smtp.live.com";
                ClienteSmtp.Port = 587;

            }
            else if (_Servidor == 2)
            {
                //"live.com.mx"
                ClienteSmtp.Host = "smtp.live.com";
                ClienteSmtp.Port = 587;
            }
            else if (_Servidor == 3)
            {
                //"gmail.com"
                ClienteSmtp.Host = "smtp.gmail.com";
                ClienteSmtp.Port = 587;
            }
            else if (_Servidor == 4)
            {
                //"yahoo.com.mx"
                ClienteSmtp.Host = "smtp.mail.yahoo.com";
                ClienteSmtp.Port = 465;
            }

            //Se envia el correo
            ClienteSmtp.Credentials = new NetworkCredential(_De, _Contraseña);
            ClienteSmtp.EnableSsl = true;

            try
            {
                ClienteSmtp.Send(msg);
                MessageBox.Show("Mensaje enviado!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al enviar el correo electrónico: " + ex.Message);
            }
            ClienteSmtp.EnableSsl = false;
            ClienteSmtp.UseDefaultCredentials = false;
            msg.Dispose();//LIBERA LA MEMORIA
        }
        private void Obtiene_Datos()
        {
            #region Consulta a la base de datos
            OleDbConnection con = new OleDbConnection();
            OleDbCommand coman = new OleDbCommand();
            OleDbDataReader dr;
            con.ConnectionString = ObtenerString();
            coman.Connection = con;
            coman.CommandText = "SELECT * FROM V_Informacion";
            coman.CommandType = CommandType.Text;
            con.Open();
            dr = coman.ExecuteReader();
            while (dr.Read())
            {
                //Declarando Variables y obteniendo los valores correspondiente
                _De = dr.GetString(dr.GetOrdinal("Correo_Electronico"));
                _Servidor = dr.GetInt32(dr.GetOrdinal("Servidor"));
                _Contraseña = dr.GetString(dr.GetOrdinal("Contraseña"));
            }
            con.Close();
            #endregion
        }
        //-------------------------------------------------------------
        //-------------------------CONEXION----------------------------
        //-------------------------------------------------------------
        #region Cadena de conexión
        //OBTIENE LA CADENA DE CONEXION
        public static string ObtenerString()
        {
            return Settings.Default.SHAJOBEConnectionString;
        }
        #endregion
    }
}
