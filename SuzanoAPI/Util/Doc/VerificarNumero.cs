using SuzanoAPI.Request.Util;

namespace SuzanoAPI.Util.Doc
{
    public class VerificarNumero
    {
        public static bool VerificarDoc(RequestBodyUtilJson doc)
        {
            if (doc is null) return false;

            int d1, d2;
            double soma = 0;
            if (doc.Documento.Length == 11)
            {
                int[] mult1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] mult2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 9; i++)
                {
                    soma += mult1[i] * Convert.ToDouble(doc.Documento.Substring(i, 1));
                }
                if (soma % 11 >= 2)
                {
                    d1 = 11 - (int)(soma % 11);
                }
                else d1 = 0;

                soma = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma += mult2[i] * Convert.ToDouble(doc.Documento.Substring(i, 1));
                }
                if (soma % 11 >= 2)
                {
                    d2 = 11 - (int)(soma % 11);
                }
                else d2 = 0;

                return d1 == Convert.ToInt32(doc.Documento.Substring(9, 1)) && d2 == Convert.ToInt32(doc.Documento.Substring(10, 1));
            }


            if (doc.Documento.Length == 14)
            {
                int[] mult1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] mult2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 12; i++)
                {
                    soma += mult1[i] * Convert.ToDouble(doc.Documento.Substring(i, 1));
                }
                if (soma % 11 >= 2)
                {
                    d1 = 11 - (int)(soma % 11);
                }
                else d1 = 0;

                soma = 0;

                for (int i = 0; i < 13; i++)
                {
                    soma += mult2[i] * Convert.ToDouble(doc.Documento.Substring(i, 1));
                }
                if (soma % 11 >= 2)
                {
                    d2 = 11 - (int)(soma % 11);
                }
                else d2 = 0;

                return d1 == Convert.ToInt32(doc.Documento.Substring(12, 1)) && d2 == Convert.ToInt32(doc.Documento.Substring(13, 1));
            }
            return false;
        }
    }
}
