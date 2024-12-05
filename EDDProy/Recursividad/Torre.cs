using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{

    public static class Torre
    {
        public static string Resolver(int n, string origen, string destino, string auxiliar)
        {
            if (n <= 0)
            {
                throw new ArgumentException("El número de discos debe ser mayor a 0.");
            }

            var pasos = new StringBuilder();
            ResolverHanoi(n, origen, destino, auxiliar, pasos);
            return pasos.ToString();
        }

        private static void ResolverHanoi(int n, string origen, string destino, string auxiliar, StringBuilder pasos)
        {
            if (n == 1)
            {
                pasos.AppendLine($"Mover disco 1 de {origen} a {destino}");
                return;
            }

            ResolverHanoi(n - 1, origen, auxiliar, destino, pasos);
            pasos.AppendLine($"Mover disco {n} de {origen} a {destino}");
            ResolverHanoi(n - 1, auxiliar, destino, origen, pasos);
        }
    }
}


