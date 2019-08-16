using System;
using System.Collections.Generic;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class TbldevolucionNoconforme
    {
        public int Intdncnumero { get; set; }
        public DateTime? DatdncfechaNc { get; set; }
        public double? FlodnccantidadNc { get; set; }
        public double? FlodncpesokCantidadNc { get; set; }
        public int? IntdncnumeroOdpDetecto { get; set; }
        public string VardncprocesoOdpDetecto { get; set; }
        public double? FlodnccantidadOrdenadaOdpDetecto { get; set; }
        public string VardncreferenciaOdpDetecto { get; set; }
        public string VardncoperarioDetecto { get; set; }
        public int? IntdnccodigoMotivoNc { get; set; }
        public int? IntdnccodigoDebidoa { get; set; }
        public string VardncreferenciaNc { get; set; }
        public int? IntdncnumeroOdpNc { get; set; }
        public int? IntdnccodigoProcesoNc { get; set; }
        public string VardncoperariosNc { get; set; }
        public string VardncmaquinasNc { get; set; }
        public string VardncprocesoNc { get; set; }
        public TimeSpan? TimdnchoraNc { get; set; }
        public double? FlodnccantidadNcPorsolucionar { get; set; }
        public string VardnccantidadNcSolucionada { get; set; }
        public int? IntdncncSolucionada { get; set; }
        public string VardncsolucionDadaNc { get; set; }
        public string VardncoperariosSolucionaronNc { get; set; }
        public int? IntdncestadoOdpDetecto { get; set; }
        public double? FlodnccantidadNcReprocesada { get; set; }
        public double? FlodnccantidadNcReclasificada { get; set; }
        public double? FlodnccantidadNcDerogada { get; set; }
        public double? FlodnccantidadNcDesperdiciada { get; set; }
        public string VardncdescripcionReferenciaOdpDetecto { get; set; }
        public int? IntdnccodigoProcesoOdpDetecto { get; set; }
        public int? IntdnccodigoOperarioDetecto { get; set; }
        public string VardncdescripcionReferenciaNc { get; set; }
        public string VardncmotivoNc { get; set; }
        public string VardncalistadorRegistroNc { get; set; }
        public string VardncreferenciasEnviadasZa { get; set; }
        public string VardnccantidadReferenciasEnviadasZa { get; set; }
        public int? IntdncnumeroReferenciasEnviadasZa { get; set; }
        public string VardncalistadoresNc { get; set; }
    }
}
