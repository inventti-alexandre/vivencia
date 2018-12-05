using Software.Basico.DB.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico.DB.Reserva
{
    class ReservaDatabase
    {
        AzureBiblioteca db = new AzureBiblioteca();


        public void CadastrarReserva(tb_reserva dto)
        {
            db.tb_reserva.Add(dto);
            db.SaveChanges();
        }
        public void AlterarReserva(tb_reserva dto, int id_reserva)
        {
            tb_reserva reserva = db.tb_reserva.Where(x => x.id_reserva == id_reserva).ToList().Single();

            reserva.tb_livro = dto.tb_livro;
            reserva.tb_livro_id_livro = dto.tb_livro_id_livro;
            reserva.tb_locatario = dto.tb_locatario;
            reserva.tb_locatario_id_locatario = dto.tb_locatario_id_locatario;
            reserva.tb_turma_aluno = dto.tb_turma_aluno;
            reserva.tb_turma_aluno_id_turma_aluno = dto.tb_turma_aluno_id_turma_aluno;

            db.SaveChanges();
        }
        public void RemoverReserva(int idReserva)
        {
            var reserv = new tb_reserva { id_reserva = idReserva };
            db.Entry(reserv).State = EntityState.Deleted;
            db.SaveChanges();
        }
        public List<vw_reserva> ConsultarReservas()
        {
            List<vw_reserva> livList = db.vw_reserva.ToList();
            return livList;
        }
        public tb_reserva ConsultarReservaid(int idReserva)
        {
            tb_reserva reversa = db.tb_reserva.Where(x => x.id_reserva == idReserva).ToList().Single();
            return reversa;
        }
        //rever essa consulta
        public tb_reserva ConsultarReservaPorNome(int Nmnome)
        {
            tb_reserva reservas = db.tb_reserva.Where(x => x.tb_locatario_id_locatario == Nmnome).ToList().Single();
            return reservas;
        }
    }
}
