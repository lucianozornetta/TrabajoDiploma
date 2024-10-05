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
    }
}
