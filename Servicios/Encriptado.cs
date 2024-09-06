using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Encriptado
    {
        public string Encriptar(BEUsuario usuario)
        {
            UnicodeEncoding uecodigo = new UnicodeEncoding();
            byte[] bytesoucetext = uecodigo.GetBytes(usuario.Contraseña);
            SHA1CryptoServiceProvider SHA = new SHA1CryptoServiceProvider();
            byte[] ByteHash = SHA.ComputeHash(uecodigo.GetBytes(usuario.Contraseña));
            usuario.Contraseña = Convert.ToBase64String(ByteHash);
            return usuario.Contraseña;
        }
    }
}
