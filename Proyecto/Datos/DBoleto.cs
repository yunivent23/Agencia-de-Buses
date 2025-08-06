using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DBoleto
    {
        public String Registrar(Boletos boleto)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Boletos.Add(boleto);
                    context.SaveChanges();
                }
                return "Boleto registrado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al registrar el Boleto: " + ex.Message;
            }
        }

        public string Modificar(string idBoletoOriginal, Boletos nuevoBoleto)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Boletos boletoOriginal = context.Boletos.Find(idBoletoOriginal);
                    if (boletoOriginal == null)
                    {
                        return "Boleto original no encontrado.";
                    }
                    context.Boletos.Remove(boletoOriginal);
                    context.Boletos.Add(nuevoBoleto);

                    context.SaveChanges();
                    return "Boleto actualizado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar el Boleto: " + ex.Message;
            }
        }


        public bool ExisteIdBoleto(string idBoleto)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    return context.Boletos.Any(b => b.Id_Boleto == idBoleto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar existencia del boleto: " + ex.Message);
            }
        }



        public String Eliminar(string id_boleto)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    Boletos boletoTemp = context.Boletos.Find(id_boleto);
                    if (boletoTemp == null)
                    {
                        return "Boleto no encontrado para eliminar.";
                    }
                    context.Boletos.Remove(boletoTemp);
                    context.SaveChanges();
                }
                return "Boleto eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el Boleto: " + ex.Message;
            }
        }

        public List<Boletos> ListarTodo()
        {
            List<Boletos> boletos = new List<Boletos>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    boletos = context.Boletos.ToList();
                }
                return boletos;
            }
            catch (Exception ex)
            {
                return boletos;
            }
        }
        //agregado
        public List<Boletos> ListarPorViaje(int idViaje)
        {
            List<Boletos> boletos = new List<Boletos>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    boletos = context.Boletos
                                     .Where(b => b.Id_Viaje == idViaje)
                                     .ToList();
                }
            }
            catch (Exception ex)
            {
               
            }
            return boletos;
        }

        public List<Boletos> ListarPorAsiento(string idAsiento)
        {
            List<Boletos> boletos = new List<Boletos>();
            try
            {
                using (var context = new BDEFEntities2())
                {
                    boletos = context.Boletos
                                     .Where(b => b.Id_Asiento == idAsiento)
                                     .ToList();
                }
            }
            catch (Exception ex)
            {
                // Manejo de error
            }
            return boletos;
        }


        //Asiento OCUPADOS POR VIAJE

        public List<string> ObtenerAsientosOcupadosPorViaje(int idViaje)
        {
            try
            {
                using (var context = new BDEFEntities2())
                {
                    return context.Boletos
                                  .Where(b => b.Id_Viaje == idViaje)
                                  .Select(b => b.Id_Asiento)
                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener asientos ocupados: " + ex.Message);
            }
        }

        public Boletos BuscarPorId(string idBoleto)
        {
            using (var context = new BDEFEntities2())
            {
                return context.Boletos.Find(idBoleto);
            }
        }

    }
}
