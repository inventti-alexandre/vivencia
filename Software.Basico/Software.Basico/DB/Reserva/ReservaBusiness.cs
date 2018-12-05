using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Reserva
{
    class ReservaBusiness
    {
       ReservaDatabase db = new ReservaDatabase();

        public void SalvarReserva (tb_reserva dto)
        {
            if (dto.tb_livro_id_livro == 0)
            {
                throw new ArgumentException("Por favor Escolha um livro.");
            }

 
            db.CadastrarReserva(dto);

        }

        public void AlterarReserva (tb_reserva dto, int idreserva)
        {
            db.AlterarReserva(dto, idreserva);
        }

        public void RemoverDados (int idreserva)
        {
            db.RemoverReserva(idreserva);
        }

        public List<vw_reserva> ConsultarReservas ()
        {
            return db.ConsultarReservas();
        }

        public tb_reserva ConsultarPorID (int id)
        {
            return db.ConsultarReservaid(id);
        }
        //rever essa consulta
        public tb_reserva ConsultarPorNome(int nome)
        {
            return db.ConsultarReservaPorNome(nome);
        }

    }
}
