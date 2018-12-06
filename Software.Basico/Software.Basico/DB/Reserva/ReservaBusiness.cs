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

            if (dto.tb_turma_aluno_id_turma_aluno == 0|| dto.tb_locatario_id_locatario ==0)
            {
                throw new ArgumentException("Por favor identifique para quem a reserva será feita.");
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

        public tb_reserva ConsultarPorID (int id)
        {
            return db.ConsultarReservaid(id);
        }
        //rever essa consulta
        public tb_reserva ConsultarPorNome(int nome)
        {
            return db.ConsultarReservaPorNome(nome);
        }

        public List<vw_reserva_locatario> ListaReservadoLocatario()
        {
            return db.ListaReservadoLocatario();
        }

        public List<vw_reserva_locatario> ConsultarReservadoLocatarioPorNome(string nome)
        {
            return db.ConsultarReservadoLocatarioPorNome(nome);
        }

        public List<vw_reserva_aluno> ListaReservadoAluno()
        {
            List<vw_reserva_aluno> dto = db.ListaReservadoAluno();
            return dto;
        }

        public List<vw_reserva_aluno> ConsultarReservadoLocatarioPorNomeAluno(string NomeAluno)
        {
            List<vw_reserva_aluno> dto = db.ConsultarReservadoLocatarioPorNomeAluno(NomeAluno);
            return dto;
        }

    }
}
