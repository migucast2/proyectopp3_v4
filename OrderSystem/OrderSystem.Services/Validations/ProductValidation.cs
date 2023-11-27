using OrderSystem.BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Services.Validations
{
    public class ProductValidation
    {
        StringBuilder ErrorResult = new StringBuilder();
        public string CamposRequeridos(Product productToValidate)
        {
            
            if (productToValidate.Name.Trim().Length == 0)
                ErrorResult.AppendLine("El campo Nombre es requerido");


            //Revisar
            else if (productToValidate.UnitPrice.ToString().Length == 0)
                ErrorResult.AppendLine("El campo Precio es requerido");
            


            return ErrorResult.ToString();
        }

        public string DatosValidos(Product productToValidate)
        {

            if (productToValidate.UnitPrice <= 0)
                ErrorResult.AppendLine("El campo Precio debe ser >= 0");

            
            return ErrorResult.ToString();

        }



    }
}
