using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfacesRepositorios;


namespace Repositorios
{
    public class RepositorioUsuarioEF : IRepositorioUsuarios
    {

        public ViveroContext ContextoViv { get; set; }

        public RepositorioUsuarioEF(ViveroContext contexto)
        {

            ContextoViv = contexto;

        }

        public bool Add(Usuario obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    if (obj.Validar())
                    {

                        if (AutenticarUserRepetido(obj.Email) == false)
                        {
                            ContextoViv.Usuarios.Add(obj);
                            ContextoViv.SaveChanges();
                            ok = true;
                        }   
                    }
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return ok;
        }

     





        public bool AutenticarUserRepetido(string email)
        {
            bool us = ContextoViv.Usuarios.Any(e => e.Email.Equals(email));
            return us;
        }

        public Usuario AutenticarU(string email, string pass)
        {
            Usuario us = ContextoViv.Usuarios.Where(e => e.Email == email && e.Pass == pass).SingleOrDefault();
            return us;
        }

        public IEnumerable<Usuario> FindAll()
        {
            return ContextoViv.Usuarios.ToList();
        }

        public Usuario FindByID(int id)
        {
            return ContextoViv.Usuarios.Find(id);
        }

        public bool Remove(Usuario obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {

                    Usuario u = new Usuario { Id = obj.Id };
                    ContextoViv.Usuarios.Remove(u);
                    int afectadas = ContextoViv.SaveChanges();
                    ok = afectadas > 0;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return ok;
        }

        public bool Update(Usuario obj)
        {
            bool ok = false;
            try
            {
                if (obj != null)
                {
                    if (obj.Validar())
                    {
                        ContextoViv.Usuarios.Update(obj);
                        int afectadas = ContextoViv.SaveChanges();
                        ok = afectadas > 0;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


            return ok;
        }
    }
}
