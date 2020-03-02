using System;

namespace Pivot.Domain.Infraestrutura
{
    public class Enums
    {
        public enum PricePoint
        {
            ABC,AA,A,B,C,AB,BC
        }

        public enum FaixaEtaria
        {
            Todas,
            Jovem,
            Adulto,
            Infantil
        }

        public enum ModeloOperacional
        {
            Franquia,
            LojaPropria
        }

        public enum Abrangencia
        {
            Nacional,
            Regional,
            Local
        }
    }
}
