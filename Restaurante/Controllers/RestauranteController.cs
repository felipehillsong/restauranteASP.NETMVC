using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class RestauranteController : Controller
    {
        public IActionResult Pedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            var pedido = new Pedido();
            pedido.Nome = "Felipe";
            pedido.Mesa = 1;
            pedido.Pratos = "Macarrão";
            pedido.QtdPratos = 1;
            pedido.Bebidas = "Coca";
            pedido.QtdBebidas = 1;
            pedido.Sobremesas = "Sorvete";
            pedido.QtdSobremesas = 1;    
             

            pedidos.Add(pedido);           

            return View(pedidos);
        }
        
        [HttpPost]
        public ActionResult Pedidos(Pedido person) {
            string nomeCliente = person.Nome;
            int numeroMesa = person.Mesa;
            string nomePrato = person.Pratos;
            int QntdPrato = person.QtdPratos;
            string nomeBebida = person.Bebidas;
            int QntdBebida = person.QtdBebidas;
            string nomeSobremesa = person.Sobremesas;
            int QntdSobremesa = person.QtdSobremesas;



            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";


            /*string Query = "INSERT INTO produtos (bebida) values ('" + person.NomeProduto + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            */

            return View();
        }

    }
}