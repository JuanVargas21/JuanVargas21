using Anun.API.Helpers;
using Anun.SHARED.Entities;
using Anun.SHARED.Enums;
using Microsoft.EntityFrameworkCore;

namespace Anun.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _contex;

        private readonly IUserHelper _userHelper;
        public SeedDb(DataContext contex, IUserHelper userHelper)
        {
            _contex = contex;
            _userHelper = userHelper;

        }

        public async Task SeedAsync()
        {
            await _contex.Database.EnsureCreatedAsync();
            await CheckAnuncioAsync();
            await CheckClienteAsync();
            await CheckEmpleadoAsync();
            await CheckPagoAsync();
            await CheckWebAsync();
            await CheckRolesAsync();

            await CheckUserAsync("123", "OAP", "orlapez@gmail.com", "2554566", UserType.Admin);

        }
        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }

        private async Task<User> CheckUserAsync(string document, string Nombrecompleto, string email, string phone, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {

                    Document = document,
                    Nombrecompleto = Nombrecompleto,
                    Email = email,
                    UserName = email,

                    PhoneNumber = phone,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());

            }

            return user;
        }



        public async Task CheckAnuncioAsync()
        {
            if (!_contex.Anuncios.Any())
            {
                _contex.Anuncios.Add(new Anuncio { Nombre = "Los pilosos", Categoria = "alimenticio", contenido = "niñoscomiendo", Tipo = "educativo", Titular = "niguno", precio = "265" });
            }


            await _contex.SaveChangesAsync();

        }
        


        public async Task CheckClienteAsync()
        {
            if (!_contex.Clientes.Any())
            {
                _contex.Clientes.Add(new Cliente { Id = 1, Direccion = "cr49c", email = "ho9arang@gmail.com", Nombrecompleto = "Andres Felipe Holguin", Telefono = "3128251271" });
            }
            await _contex.SaveChangesAsync();
        }

        public async Task CheckEmpleadoAsync()
        {
            if (!_contex.Empleados.Any())
            {
                _contex.Empleados.Add(new Empleado { Id = 1, Nombrecompleto = "juan alberto", cargo = "asesor", email = "@gmail.com", telefono = "312776456" });
            }
            await _contex.SaveChangesAsync();
        }

        public async Task CheckPagoAsync()
        {
            if (!_contex.Pagos.Any())
            {
                _contex.Pagos.Add(new Pago { Id = 2, Fecha = new DateTime(2022, 03, 18), monto = "980.000 "});
            }
            await _contex.SaveChangesAsync();
        }
        public async Task CheckWebAsync()
        {
            if (!_contex.Webs.Any())
            {
                _contex.Webs.Add(new Web { Nombre = "confepors", Id = 2, Tema = "oscuro", Url = "https" });
            }
            await _contex.SaveChangesAsync();//
        }
        

    }
}
