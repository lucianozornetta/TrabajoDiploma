using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;


namespace BLL
{
    public class BLLTag
    {
        MPPTag mpptag;

        public bool GuardarTag(BETag tag)
        {
            mpptag = new MPPTag();
            return mpptag.GuardarTag(tag);
        } 
        public List<BETag> ListarTags()
        {
            mpptag = new MPPTag();
            return mpptag.ListarTags();
        }

        public List<BETag> DevolverTagsDeUsuario(BEUsuario usuario)
        {
            MPPUsuario mppusuario = new MPPUsuario();
            mppusuario.LeerTagsUsuario(usuario);
            return usuario.Aptitudes;
        }

        public bool ImportarListaTags(List<BETag> tagsjson)
        {
            List<BETag> tags = ListarTags();
            List<BETag> listaagregados = new List<BETag>();
            foreach(BETag tag in tags)
            {
                foreach(BETag tagjson in tagsjson)
                {
                    if(tag.Nombre == tagjson.Nombre)
                    {
                        
                    }
                    else
                    {
                        listaagregados.Add(tagjson);
                    }
                }
            }


            mpptag = new MPPTag();
            try
            {
                foreach (BETag tagjson in listaagregados)
                {
                    mpptag.GuardarTag(tagjson);
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
