using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Service.Services
{
    public class InventarioService : IInventarioService
    {
        private readonly IProductoRepository _productoRepository;
        public InventarioService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public void SendEmail(List<Producto> productos, string user, string email)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("alanjuker@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Banding | Stock Mínimo";
                string listaProductos = "";
                foreach (var item in productos)
                {
                    item.EmailEnviado = "1";
                    _productoRepository.UpdateProducto(item);
                    listaProductos += "<li>" + item.NombreProducto + "</li>";
                }

                mail.Body = $"Hola, {user} los siguientes productos han llegado a su stock mínimo!.</br> <ul>{listaProductos}</ul> </br> Recomendamos tomar las medidas necesarias.";
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("alanjuker@gmail.com", "9709baby");
                    smtp.Send(mail);
                }
            }
        }
    }
}
