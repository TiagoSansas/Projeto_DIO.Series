using System.Collections.Generic;
using DIO.Series.Intefaces;

namespace DIO.Series

{
    public class ISeriesRepositorio : IRepository<Series>
    {
        public void Atualiza(int id, Series entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insere(Series entidade)
        {
            throw new System.NotImplementedException();
        }

        public List<Series> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Series RetornaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}