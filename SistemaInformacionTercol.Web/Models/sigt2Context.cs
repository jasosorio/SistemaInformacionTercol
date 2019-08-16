using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaInformacionTercol.Web.Models
{
    public partial class sigt2Context : DbContext
    {
        public sigt2Context()
        {
        }

        public sigt2Context(DbContextOptions<sigt2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblalertas> Tblalertas { get; set; }
        public virtual DbSet<Tblciudad> Tblciudad { get; set; }
        public virtual DbSet<Tblcliente> Tblcliente { get; set; }
        public virtual DbSet<Tblclientet> Tblclientet { get; set; }
        public virtual DbSet<TblconsecutivoDocumentos> TblconsecutivoDocumentos { get; set; }
        public virtual DbSet<TblcontactoCliente> TblcontactoCliente { get; set; }
        public virtual DbSet<TbldatosEvaluacion> TbldatosEvaluacion { get; set; }
        public virtual DbSet<TbldatosProcesodp> TbldatosProcesodp { get; set; }
        public virtual DbSet<Tbldepartamento> Tbldepartamento { get; set; }
        public virtual DbSet<TbldescuentoCliente> TbldescuentoCliente { get; set; }
        public virtual DbSet<Tbldesperdicio> Tbldesperdicio { get; set; }
        public virtual DbSet<TbldetalleConsecutivoDocumentos> TbldetalleConsecutivoDocumentos { get; set; }
        public virtual DbSet<TbldetalleDocumentoRecepcion> TbldetalleDocumentoRecepcion { get; set; }
        public virtual DbSet<TbldetalleOrdenProduccion> TbldetalleOrdenProduccion { get; set; }
        public virtual DbSet<TbldevolucionNoconforme> TbldevolucionNoconforme { get; set; }
        public virtual DbSet<TbldireccionCliente> TbldireccionCliente { get; set; }
        public virtual DbSet<TbldocumentoRecepcion> TbldocumentoRecepcion { get; set; }
        public virtual DbSet<TblemailCliente> TblemailCliente { get; set; }
        public virtual DbSet<TblevaluacionOdcs> TblevaluacionOdcs { get; set; }
        public virtual DbSet<TblitemsOdc> TblitemsOdc { get; set; }
        public virtual DbSet<TblitemsRecepcionProveedors> TblitemsRecepcionProveedors { get; set; }
        public virtual DbSet<TblitemsRemision1> TblitemsRemision1 { get; set; }
        public virtual DbSet<TblitemsTemporalGodcs> TblitemsTemporalGodcs { get; set; }
        public virtual DbSet<TblitemsTemporalGremision> TblitemsTemporalGremision { get; set; }
        public virtual DbSet<TblitemsTemporalOds> TblitemsTemporalOds { get; set; }
        public virtual DbSet<Tbllineas> Tbllineas { get; set; }
        public virtual DbSet<Tblmaquina> Tblmaquina { get; set; }
        public virtual DbSet<TblmateriaPrima> TblmateriaPrima { get; set; }
        public virtual DbSet<TblmaterialesAjuste> TblmaterialesAjuste { get; set; }
        public virtual DbSet<TblmaterialesPlanta> TblmaterialesPlanta { get; set; }
        public virtual DbSet<TblmaterialesRemision> TblmaterialesRemision { get; set; }
        public virtual DbSet<TblmaterialesRemision1> TblmaterialesRemision1 { get; set; }
        public virtual DbSet<TblmotivoDevolucion> TblmotivoDevolucion { get; set; }
        public virtual DbSet<Tblmovimiento> Tblmovimiento { get; set; }
        public virtual DbSet<Tblnovedades> Tblnovedades { get; set; }
        public virtual DbSet<Tbloperario> Tbloperario { get; set; }
        public virtual DbSet<TblordenCompra> TblordenCompra { get; set; }
        public virtual DbSet<TblordenProduccion> TblordenProduccion { get; set; }
        public virtual DbSet<Tblpadre> Tblpadre { get; set; }
        public virtual DbSet<Tblpais> Tblpais { get; set; }
        public virtual DbSet<Tblplanta> Tblplanta { get; set; }
        public virtual DbSet<TblprocesoMaquina> TblprocesoMaquina { get; set; }
        public virtual DbSet<TblprocesoOperario> TblprocesoOperario { get; set; }
        public virtual DbSet<TblprocesoProducto> TblprocesoProducto { get; set; }
        public virtual DbSet<Tblprocesoe> Tblprocesoe { get; set; }
        public virtual DbSet<TblproductoProceso> TblproductoProceso { get; set; }
        public virtual DbSet<TblproductoTerminado> TblproductoTerminado { get; set; }
        public virtual DbSet<TblproductosCliente> TblproductosCliente { get; set; }
        public virtual DbSet<Tblproveedor> Tblproveedor { get; set; }
        public virtual DbSet<Tblproveedormp> Tblproveedormp { get; set; }
        public virtual DbSet<Tblproveedors> Tblproveedors { get; set; }
        public virtual DbSet<TblrecepcionPlanta> TblrecepcionPlanta { get; set; }
        public virtual DbSet<TblrecepcionProveedors> TblrecepcionProveedors { get; set; }
        public virtual DbSet<Tblrecmatpvs> Tblrecmatpvs { get; set; }
        public virtual DbSet<Tblremision> Tblremision { get; set; }
        public virtual DbSet<Tblremision1> Tblremision1 { get; set; }
        public virtual DbSet<TblsegOpcionMenu> TblsegOpcionMenu { get; set; }
        public virtual DbSet<TblsegOpcionMenuant> TblsegOpcionMenuant { get; set; }
        public virtual DbSet<TblsegOpcionPerfil> TblsegOpcionPerfil { get; set; }
        public virtual DbSet<TblsegOpcionPerfilant> TblsegOpcionPerfilant { get; set; }
        public virtual DbSet<TblsegPerfiles> TblsegPerfiles { get; set; }
        public virtual DbSet<TblsegPerfilesant> TblsegPerfilesant { get; set; }
        public virtual DbSet<TbltelefonoCliente> TbltelefonoCliente { get; set; }
        public virtual DbSet<Tbltemp> Tbltemp { get; set; }
        public virtual DbSet<Tbltemp1> Tbltemp1 { get; set; }
        public virtual DbSet<Tbltemp2> Tbltemp2 { get; set; }
        public virtual DbSet<TbltemporalGodcs> TbltemporalGodcs { get; set; }
        public virtual DbSet<TbltemporalGremision> TbltemporalGremision { get; set; }
        public virtual DbSet<TbltemporalOds> TbltemporalOds { get; set; }
        public virtual DbSet<TbltipoProceso> TbltipoProceso { get; set; }
        public virtual DbSet<Tblusuarios> Tblusuarios { get; set; }
        public virtual DbSet<Tblusuariosant> Tblusuariosant { get; set; }
        public virtual DbSet<TblzonaAmarilla> TblzonaAmarilla { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SERVI_SIT\\SQLEXPRESS02;Database=sigt(2);Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Tblalertas>(entity =>
            {
                entity.HasKey(e => e.Intalerconsecutivo)
                    .HasName("PK__tblalert__4FE08CB1E62F0C21");

                entity.ToTable("tblalertas");

                entity.Property(e => e.Intalerconsecutivo)
                    .HasColumnName("intalerconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intalerbandera)
                    .HasColumnName("intalerbandera")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varalerdescripcion)
                    .HasColumnName("varalerdescripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblciudad>(entity =>
            {
                entity.HasKey(e => e.Intciucodigo)
                    .HasName("PK__tblciuda__2CEC2C790C8E3CBB");

                entity.ToTable("tblciudad");

                entity.Property(e => e.Intciucodigo)
                    .HasColumnName("intciucodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intciudepartamento)
                    .HasColumnName("intciudepartamento")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varciunombre)
                    .HasColumnName("varciunombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblcliente>(entity =>
            {
                entity.HasKey(e => e.Intclconsecutivo)
                    .HasName("PK__tblclien__9FD8FF9AB433114D");

                entity.ToTable("tblcliente");

                entity.Property(e => e.Intclconsecutivo)
                    .HasColumnName("intclconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Floclcantidad).HasColumnName("floclcantidad");

                entity.Property(e => e.VarclrazonSocial)
                    .HasColumnName("varclrazon_social")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VarclreferenciaProducto)
                    .HasColumnName("varclreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarcltipoReferencia)
                    .HasColumnName("varcltipo_referencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varclunidad)
                    .HasColumnName("varclunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblclientet>(entity =>
            {
                entity.HasKey(e => e.Intcltcodigo)
                    .HasName("PK__tblclien__972621AC5598BDF0");

                entity.ToTable("tblclientet");

                entity.Property(e => e.Intcltcodigo)
                    .HasColumnName("intcltcodigo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DatcltfechaEvaluacion)
                    .HasColumnName("datcltfecha_evaluacion")
                    .HasColumnType("date");

                entity.Property(e => e.DatcltfechaIngreso)
                    .HasColumnName("datcltfecha_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.Flocltdescuento).HasColumnName("flocltdescuento");

                entity.Property(e => e.Flocltdescuentov).HasColumnName("flocltdescuentov");

                entity.Property(e => e.Flocltevaluacion).HasColumnName("flocltevaluacion");

                entity.Property(e => e.Intcltciudad)
                    .HasColumnName("intcltciudad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntcltcontroladoCalidad)
                    .HasColumnName("intcltcontrolado_calidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intcltestado)
                    .HasColumnName("intcltestado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intcltplazo)
                    .HasColumnName("intcltplazo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntclttiempoEntrega)
                    .HasColumnName("intclttiempo_entrega")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntclttipoCalidad)
                    .HasColumnName("intclttipo_calidad")
                    .HasDefaultValueSql("('3')");

                entity.Property(e => e.Varcltactualizaciones)
                    .HasColumnName("varcltactualizaciones")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varcltciudad)
                    .HasColumnName("varcltciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varcltcontacto)
                    .HasColumnName("varcltcontacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varcltdireccion)
                    .HasColumnName("varcltdireccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varcltemail)
                    .HasColumnName("varcltemail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarcltevaluacionesCalidad)
                    .HasColumnName("varcltevaluaciones_calidad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varcltfax)
                    .HasColumnName("varcltfax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varcltnit)
                    .HasColumnName("varcltnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varcltproducto)
                    .HasColumnName("varcltproducto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarcltquienRealiza)
                    .HasColumnName("varcltquien_realiza")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarcltrazonSocial)
                    .HasColumnName("varcltrazon_social")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varclttelefono)
                    .HasColumnName("varclttelefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblconsecutivoDocumentos>(entity =>
            {
                entity.HasKey(e => e.Intcdid)
                    .HasName("PK__tblconse__D55293F892E5ACB6");

                entity.ToTable("tblconsecutivo_documentos");

                entity.Property(e => e.Intcdid)
                    .HasColumnName("intcdid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intcdnumero)
                    .HasColumnName("intcdnumero")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TblcontactoCliente>(entity =>
            {
                entity.HasKey(e => e.Intcccodigo)
                    .HasName("PK__tblconta__BA714A9C6F1C645C");

                entity.ToTable("tblcontacto_cliente");

                entity.Property(e => e.Intcccodigo)
                    .HasColumnName("intcccodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intcccliente)
                    .HasColumnName("intcccliente")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varcccontacto)
                    .HasColumnName("varcccontacto")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldatosEvaluacion>(entity =>
            {
                entity.HasKey(e => e.Intdeconsecutivo)
                    .HasName("PK__tbldatos__46D21D0A3E3D6069");

                entity.ToTable("tbldatos_evaluacion");

                entity.Property(e => e.Intdeconsecutivo)
                    .HasColumnName("intdeconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datdefecha)
                    .HasColumnName("datdefecha")
                    .HasColumnType("date");

                entity.Property(e => e.FlodecantidadRecibida).HasColumnName("flodecantidad_recibida");

                entity.Property(e => e.FlodecantidadVerificada).HasColumnName("flodecantidad_verificada");

                entity.Property(e => e.Flodeporcalidad).HasColumnName("flodeporcalidad");

                entity.Property(e => e.Flodeporcantidad).HasColumnName("flodeporcantidad");

                entity.Property(e => e.Flodeportiempo).HasColumnName("flodeportiempo");

                entity.Property(e => e.Intdenodcs)
                    .HasColumnName("intdenodcs")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdevalcalidad)
                    .HasColumnName("intdevalcalidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdevalcantidad)
                    .HasColumnName("intdevalcantidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdevaltiempo)
                    .HasColumnName("intdevaltiempo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Vardeproveedor)
                    .HasColumnName("vardeproveedor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardereferenciaProducto)
                    .HasColumnName("vardereferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varderesponsable)
                    .HasColumnName("varderesponsable")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldatosProcesodp>(entity =>
            {
                entity.HasKey(e => e.Intdpoconsecutivo)
                    .HasName("PK__tbldatos__A422EBC59359F11C");

                entity.ToTable("tbldatos_procesodp");

                entity.Property(e => e.Intdpoconsecutivo)
                    .HasColumnName("intdpoconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datdpofechafin)
                    .HasColumnName("datdpofechafin")
                    .HasColumnType("date");

                entity.Property(e => e.Datdpofechaini)
                    .HasColumnName("datdpofechaini")
                    .HasColumnType("date");

                entity.Property(e => e.Flodpocantidad).HasColumnName("flodpocantidad");

                entity.Property(e => e.Flodpocostocan).HasColumnName("flodpocostocan");

                entity.Property(e => e.Flodpocostouni).HasColumnName("flodpocostouni");

                entity.Property(e => e.Flodpoduracionh).HasColumnName("flodpoduracionh");

                entity.Property(e => e.Intdpoalis)
                    .HasColumnName("intdpoalis")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdpoayudante)
                    .HasColumnName("intdpoayudante")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdpocodigoOperario)
                    .HasColumnName("intdpocodigo_operario")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdpocodigoProceso)
                    .HasColumnName("intdpocodigo_proceso")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdpoinspeccion)
                    .HasColumnName("intdpoinspeccion")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdpoinspeccion1)
                    .HasColumnName("intdpoinspeccion1")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdponumeroOrden)
                    .HasColumnName("intdponumero_orden")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdpopasada)
                    .HasColumnName("intdpopasada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdpopasada1)
                    .HasColumnName("intdpopasada1")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdpotermino)
                    .HasColumnName("intdpotermino")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdpotermino1)
                    .HasColumnName("intdpotermino1")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Timdpohorafin).HasColumnName("timdpohorafin");

                entity.Property(e => e.Timdpohoraini).HasColumnName("timdpohoraini");
            });

            modelBuilder.Entity<Tbldepartamento>(entity =>
            {
                entity.HasKey(e => e.Intdepcodigo)
                    .HasName("PK__tbldepar__9B89D5F41B880301");

                entity.ToTable("tbldepartamento");

                entity.Property(e => e.Intdepcodigo)
                    .HasColumnName("intdepcodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intdeppais)
                    .HasColumnName("intdeppais")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Vardepnombre)
                    .HasColumnName("vardepnombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldescuentoCliente>(entity =>
            {
                entity.HasKey(e => e.Intdeccodigo)
                    .HasName("PK__tbldescu__54847419AA42BB53");

                entity.ToTable("tbldescuento_cliente");

                entity.Property(e => e.Intdeccodigo)
                    .HasColumnName("intdeccodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flodecdescuento)
                    .HasColumnName("flodecdescuento")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdeccliente)
                    .HasColumnName("intdeccliente")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdectipoDescuento)
                    .HasColumnName("intdectipo_descuento")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Tbldesperdicio>(entity =>
            {
                entity.HasKey(e => e.Intdsconsecutivo)
                    .HasName("PK__tbldespe__92C12E272886ABB6");

                entity.ToTable("tbldesperdicio");

                entity.Property(e => e.Intdsconsecutivo)
                    .HasColumnName("intdsconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flodscantidad).HasColumnName("flodscantidad");

                entity.Property(e => e.VardsreferenciaProducto)
                    .HasColumnName("vardsreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VardstipoReferencia)
                    .HasColumnName("vardstipo_referencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vardsunidad)
                    .HasColumnName("vardsunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldetalleConsecutivoDocumentos>(entity =>
            {
                entity.HasKey(e => e.IntdcdnumeroItem)
                    .HasName("PK__tbldetal__6316096F560DB852");

                entity.ToTable("tbldetalle_consecutivo_documentos");

                entity.Property(e => e.IntdcdnumeroItem)
                    .HasColumnName("intdcdnumero_item")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlodcdcantidadItem).HasColumnName("flodcdcantidad_item");

                entity.Property(e => e.FlodcdcostoUnidadItem).HasColumnName("flodcdcosto_unidad_item");

                entity.Property(e => e.IntdcdnumeroCd)
                    .HasColumnName("intdcdnumero_cd")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VardcdreferenciaItem)
                    .HasColumnName("vardcdreferencia_item")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldetalleDocumentoRecepcion>(entity =>
            {
                entity.HasKey(e => e.Intddrconsecutivo)
                    .HasName("PK__tbldetal__0431F2A22FC00050");

                entity.ToTable("tbldetalle_documento_recepcion");

                entity.Property(e => e.Intddrconsecutivo)
                    .HasColumnName("intddrconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Floddrcantidad).HasColumnName("floddrcantidad");

                entity.Property(e => e.FloddrcantidadPagada).HasColumnName("floddrcantidad_pagada");

                entity.Property(e => e.IntddridDocumento)
                    .HasColumnName("intddrid_documento")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntddritemDocumento)
                    .HasColumnName("intddritem_documento")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intddrpagado)
                    .HasColumnName("intddrpagado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VarddrfechasPagoDocumento)
                    .HasColumnName("varddrfechas_pago_documento")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarddrfechasRegistroDocumento)
                    .HasColumnName("varddrfechas_registro_documento")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarddrresponsablesPagoDocumento)
                    .HasColumnName("varddrresponsables_pago_documento")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarddrresponsablesRegistroDocumento)
                    .HasColumnName("varddrresponsables_registro_documento")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldetalleOrdenProduccion>(entity =>
            {
                entity.HasKey(e => new { e.Intdoconsecutivo, e.IntdonumeroOrden, e.IntdocodigoProceso })
                    .HasName("PK__tbldetal__7AF7CD45D524FFA8");

                entity.ToTable("tbldetalle_orden_produccion");

                entity.Property(e => e.Intdoconsecutivo).HasColumnName("intdoconsecutivo");

                entity.Property(e => e.IntdonumeroOrden)
                    .HasColumnName("intdonumero_orden")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdocodigoProceso)
                    .HasColumnName("intdocodigo_proceso")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DatdofechaProceso)
                    .HasColumnName("datdofecha_proceso")
                    .HasColumnType("date");

                entity.Property(e => e.Flodocoscan).HasColumnName("flodocoscan");

                entity.Property(e => e.Flodocosuni).HasColumnName("flodocosuni");

                entity.Property(e => e.FlododuracionProceso).HasColumnName("flododuracion_proceso");

                entity.Property(e => e.IntdocantidadConforme)
                    .HasColumnName("intdocantidad_conforme")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdoinspeccion)
                    .HasColumnName("intdoinspeccion")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdoinspeccion1)
                    .HasColumnName("intdoinspeccion1")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Vardoalistador)
                    .HasColumnName("vardoalistador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardocodigoMaquina)
                    .HasColumnName("vardocodigo_maquina")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardocodigoOperario)
                    .HasColumnName("vardocodigo_operario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldevolucionNoconforme>(entity =>
            {
                entity.HasKey(e => e.Intdncnumero)
                    .HasName("PK__tbldevol__C298412834179412");

                entity.ToTable("tbldevolucion_noconforme");

                entity.Property(e => e.Intdncnumero)
                    .HasColumnName("intdncnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DatdncfechaNc)
                    .HasColumnName("datdncfecha_nc")
                    .HasColumnType("date");

                entity.Property(e => e.FlodnccantidadNc).HasColumnName("flodnccantidad_nc");

                entity.Property(e => e.FlodnccantidadNcDerogada).HasColumnName("flodnccantidad_nc_derogada");

                entity.Property(e => e.FlodnccantidadNcDesperdiciada).HasColumnName("flodnccantidad_nc_desperdiciada");

                entity.Property(e => e.FlodnccantidadNcPorsolucionar).HasColumnName("flodnccantidad_nc_porsolucionar");

                entity.Property(e => e.FlodnccantidadNcReclasificada).HasColumnName("flodnccantidad_nc_reclasificada");

                entity.Property(e => e.FlodnccantidadNcReprocesada).HasColumnName("flodnccantidad_nc_reprocesada");

                entity.Property(e => e.FlodnccantidadOrdenadaOdpDetecto).HasColumnName("flodnccantidad_ordenada_odp_detecto");

                entity.Property(e => e.FlodncpesokCantidadNc).HasColumnName("flodncpesok_cantidad_nc");

                entity.Property(e => e.IntdnccodigoDebidoa)
                    .HasColumnName("intdnccodigo_debidoa")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdnccodigoMotivoNc)
                    .HasColumnName("intdnccodigo_motivo_nc")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdnccodigoOperarioDetecto)
                    .HasColumnName("intdnccodigo_operario_detecto")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdnccodigoProcesoNc)
                    .HasColumnName("intdnccodigo_proceso_nc")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdnccodigoProcesoOdpDetecto)
                    .HasColumnName("intdnccodigo_proceso_odp_detecto")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdncestadoOdpDetecto)
                    .HasColumnName("intdncestado_odp_detecto")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdncncSolucionada)
                    .HasColumnName("intdncnc_solucionada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdncnumeroOdpDetecto)
                    .HasColumnName("intdncnumero_odp_detecto")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdncnumeroOdpNc)
                    .HasColumnName("intdncnumero_odp_nc")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdncnumeroReferenciasEnviadasZa)
                    .HasColumnName("intdncnumero_referencias_enviadas_za")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TimdnchoraNc).HasColumnName("timdnchora_nc");

                entity.Property(e => e.VardncalistadorRegistroNc)
                    .HasColumnName("vardncalistador_registro_nc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardncalistadoresNc)
                    .HasColumnName("vardncalistadores_nc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VardnccantidadNcSolucionada)
                    .HasColumnName("vardnccantidad_nc_solucionada")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardnccantidadReferenciasEnviadasZa)
                    .HasColumnName("vardnccantidad_referencias_enviadas_za")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VardncdescripcionReferenciaNc)
                    .HasColumnName("vardncdescripcion_referencia_nc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VardncdescripcionReferenciaOdpDetecto)
                    .HasColumnName("vardncdescripcion_referencia_odp_detecto")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VardncmaquinasNc)
                    .HasColumnName("vardncmaquinas_nc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardncmotivoNc)
                    .HasColumnName("vardncmotivo_nc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VardncoperarioDetecto)
                    .HasColumnName("vardncoperario_detecto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VardncoperariosNc)
                    .HasColumnName("vardncoperarios_nc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardncoperariosSolucionaronNc)
                    .HasColumnName("vardncoperarios_solucionaron_nc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardncprocesoNc)
                    .HasColumnName("vardncproceso_nc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VardncprocesoOdpDetecto)
                    .HasColumnName("vardncproceso_odp_detecto")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VardncreferenciaNc)
                    .HasColumnName("vardncreferencia_nc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VardncreferenciaOdpDetecto)
                    .HasColumnName("vardncreferencia_odp_detecto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VardncreferenciasEnviadasZa)
                    .HasColumnName("vardncreferencias_enviadas_za")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VardncsolucionDadaNc)
                    .HasColumnName("vardncsolucion_dada_nc")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldireccionCliente>(entity =>
            {
                entity.HasKey(e => e.Intdccodigo)
                    .HasName("PK__tbldirec__D3CAFE9DAE20F165");

                entity.ToTable("tbldireccion_cliente");

                entity.Property(e => e.Intdccodigo)
                    .HasColumnName("intdccodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intdcciudad)
                    .HasColumnName("intdcciudad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdccliente)
                    .HasColumnName("intdccliente")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Vardcdireccion)
                    .HasColumnName("vardcdireccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbldocumentoRecepcion>(entity =>
            {
                entity.HasKey(e => e.Intdrconsecutivo)
                    .HasName("PK__tbldocum__7E11C954031646DC");

                entity.ToTable("tbldocumento_recepcion");

                entity.Property(e => e.Intdrconsecutivo)
                    .HasColumnName("intdrconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatdrfechaGeneracion)
                    .HasColumnName("datdrfecha_generacion")
                    .HasColumnType("date");

                entity.Property(e => e.DatdrfechaPago)
                    .HasColumnName("datdrfecha_pago")
                    .HasColumnType("date");

                entity.Property(e => e.IntdrnumeroDocumento)
                    .HasColumnName("intdrnumero_documento")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdrpagado)
                    .HasColumnName("intdrpagado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intdrproveedor)
                    .HasColumnName("intdrproveedor")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdrtipoDocumento)
                    .HasColumnName("intdrtipo_documento")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntdrtipoOrden)
                    .HasColumnName("intdrtipo_orden")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VardrfechasPago)
                    .HasColumnName("vardrfechas_pago")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VardrfechasRegistro)
                    .HasColumnName("vardrfechas_registro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VardrnumeroDocumento)
                    .HasColumnName("vardrnumero_documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VardrresponsablesPago)
                    .HasColumnName("vardrresponsables_pago")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VardrresponsablesRegistro)
                    .HasColumnName("vardrresponsables_registro")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblemailCliente>(entity =>
            {
                entity.HasKey(e => e.Inteccodigo)
                    .HasName("PK__tblemail__055FC49D8DB63287");

                entity.ToTable("tblemail_cliente");

                entity.Property(e => e.Inteccodigo)
                    .HasColumnName("inteccodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Inteccliente)
                    .HasColumnName("inteccliente")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varecemail)
                    .HasColumnName("varecemail")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblevaluacionOdcs>(entity =>
            {
                entity.HasKey(e => e.Inteoconsecutivo)
                    .HasName("PK__tblevalu__0A17340DE7DEE75E");

                entity.ToTable("tblevaluacion_odcs");

                entity.Property(e => e.Inteoconsecutivo)
                    .HasColumnName("inteoconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateofechaEvaluacion)
                    .HasColumnName("dateofecha_evaluacion")
                    .HasColumnType("date");

                entity.Property(e => e.FloeocantidadRecibida).HasColumnName("floeocantidad_recibida");

                entity.Property(e => e.FloeocantidadVerificada).HasColumnName("floeocantidad_verificada");

                entity.Property(e => e.FloeoporcentajeEvaluacionCalidad).HasColumnName("floeoporcentaje_evaluacion_calidad");

                entity.Property(e => e.FloeoporcentajeEvaluacionCantidad).HasColumnName("floeoporcentaje_evaluacion_cantidad");

                entity.Property(e => e.FloeoporcentajeEvaluacionTiempo).HasColumnName("floeoporcentaje_evaluacion_tiempo");

                entity.Property(e => e.InteoevaluacionCalidad)
                    .HasColumnName("inteoevaluacion_calidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InteoevaluacionCantidad)
                    .HasColumnName("inteoevaluacion_cantidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InteoevaluacionTiempo)
                    .HasColumnName("inteoevaluacion_tiempo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InteoitemOrden)
                    .HasColumnName("inteoitem_orden")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InteonumeroOrden)
                    .HasColumnName("inteonumero_orden")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VareoresponsableEvaluacion)
                    .HasColumnName("vareoresponsable_evaluacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblitemsOdc>(entity =>
            {
                entity.HasKey(e => e.Intiodcconsecutivo)
                    .HasName("PK__tblitems__30800C1C51295312");

                entity.ToTable("tblitems_odc");

                entity.Property(e => e.Intiodcconsecutivo)
                    .HasColumnName("intiodcconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatiodcfechaEvaluacion)
                    .HasColumnName("datiodcfecha_evaluacion")
                    .HasColumnType("date");

                entity.Property(e => e.Datiodcfechaeval)
                    .HasColumnName("datiodcfechaeval")
                    .HasColumnType("date");

                entity.Property(e => e.Floiodccantidad).HasColumnName("floiodccantidad");

                entity.Property(e => e.Floiodccantidad1).HasColumnName("floiodccantidad1");

                entity.Property(e => e.FloiodccantidadOrdenada).HasColumnName("floiodccantidad_ordenada");

                entity.Property(e => e.FloiodccantidadRecibida).HasColumnName("floiodccantidad_recibida");

                entity.Property(e => e.FloiodccantidadVerificada).HasColumnName("floiodccantidad_verificada");

                entity.Property(e => e.Floiodccantidadr).HasColumnName("floiodccantidadr");

                entity.Property(e => e.Floiodccantidadver).HasColumnName("floiodccantidadver");

                entity.Property(e => e.Floiodccosto).HasColumnName("floiodccosto");

                entity.Property(e => e.FloiodccostoUnitario).HasColumnName("floiodccosto_unitario");

                entity.Property(e => e.Floiodcevalcalidad).HasColumnName("floiodcevalcalidad");

                entity.Property(e => e.Floiodcevalcantidad).HasColumnName("floiodcevalcantidad");

                entity.Property(e => e.Floiodcevaltiempo).HasColumnName("floiodcevaltiempo");

                entity.Property(e => e.FloiodcevaluacionCalidad).HasColumnName("floiodcevaluacion_calidad");

                entity.Property(e => e.FloiodcevaluacionCantidad).HasColumnName("floiodcevaluacion_cantidad");

                entity.Property(e => e.FloiodcevaluacionTiempo).HasColumnName("floiodcevaluacion_tiempo");

                entity.Property(e => e.Floiodcporcalidad).HasColumnName("floiodcporcalidad");

                entity.Property(e => e.Floiodcporcantidad).HasColumnName("floiodcporcantidad");

                entity.Property(e => e.FloiodcporcentajeEvaluacionCalidad).HasColumnName("floiodcporcentaje_evaluacion_calidad");

                entity.Property(e => e.FloiodcporcentajeEvaluacionCantidad).HasColumnName("floiodcporcentaje_evaluacion_cantidad");

                entity.Property(e => e.FloiodcporcentajeEvaluacionTiempo).HasColumnName("floiodcporcentaje_evaluacion_tiempo");

                entity.Property(e => e.Floiodcportiempo).HasColumnName("floiodcportiempo");

                entity.Property(e => e.Intiodcabierto)
                    .HasColumnName("intiodcabierto")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intiodcanulado)
                    .HasColumnName("intiodcanulado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intiodcestado)
                    .HasColumnName("intiodcestado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntiodcnumeroOdc)
                    .HasColumnName("intiodcnumero_odc")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intiodcpagado)
                    .HasColumnName("intiodcpagado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intiodcrecibido)
                    .HasColumnName("intiodcrecibido")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Variodccondiciones)
                    .HasColumnName("variodccondiciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Variodcobservaciones)
                    .HasColumnName("variodcobservaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VariodcrazonSocialProveedor)
                    .HasColumnName("variodcrazon_social_proveedor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VariodcreferenciaProducto)
                    .HasColumnName("variodcreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VariodctipoOrden)
                    .HasColumnName("variodctipo_orden")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblitemsRecepcionProveedors>(entity =>
            {
                entity.HasKey(e => e.Intirpsconsecutivo)
                    .HasName("PK__tblitems__F6298044930504BA");

                entity.ToTable("tblitems_recepcion_proveedors");

                entity.Property(e => e.Intirpsconsecutivo)
                    .HasColumnName("intirpsconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.FloirpscantidadRecibida).HasColumnName("floirpscantidad_recibida");

                entity.Property(e => e.IntirpsnumeroRps)
                    .HasColumnName("intirpsnumero_rps")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VarirpsreferenciaProducto)
                    .HasColumnName("varirpsreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblitemsRemision1>(entity =>
            {
                entity.HasKey(e => e.Intirem1consecutivo)
                    .HasName("PK__tblitems__01F2090F99BABDD4");

                entity.ToTable("tblitems_remision1");

                entity.Property(e => e.Intirem1consecutivo)
                    .HasColumnName("intirem1consecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Floirem1cantidadRemisionada).HasColumnName("floirem1cantidad_remisionada");

                entity.Property(e => e.Intirem1numeroRemision)
                    .HasColumnName("intirem1numero_remision")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varirem1referenciaProducto)
                    .HasColumnName("varirem1referencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblitemsTemporalGodcs>(entity =>
            {
                entity.HasKey(e => e.Intitgoconsecutivo)
                    .HasName("PK__tblitems__40700524EBF08032");

                entity.ToTable("tblitems_temporal_godcs");

                entity.Property(e => e.Intitgoconsecutivo)
                    .HasColumnName("intitgoconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Floitgocantidad).HasColumnName("floitgocantidad");

                entity.Property(e => e.FloitgovalorPactado).HasColumnName("floitgovalor_pactado");

                entity.Property(e => e.IntitgonumeroOdcs)
                    .HasColumnName("intitgonumero_odcs")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VaritgoreferenciaProducto)
                    .HasColumnName("varitgoreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblitemsTemporalGremision>(entity =>
            {
                entity.HasKey(e => e.Intitgrconsecutivo)
                    .HasName("PK__tblitems__0456D4FF2B404445");

                entity.ToTable("tblitems_temporal_gremision");

                entity.Property(e => e.Intitgrconsecutivo)
                    .HasColumnName("intitgrconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Floitgrcantidad).HasColumnName("floitgrcantidad");

                entity.Property(e => e.IntitgrnumeroRemision)
                    .HasColumnName("intitgrnumero_remision")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VaritgrreferenciaProducto)
                    .HasColumnName("varitgrreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblitemsTemporalOds>(entity =>
            {
                entity.HasKey(e => e.Intitoconsecutivo)
                    .HasName("PK__tblitems__67B9006820696787");

                entity.ToTable("tblitems_temporal_ods");

                entity.Property(e => e.Intitoconsecutivo)
                    .HasColumnName("intitoconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Floitocantidad).HasColumnName("floitocantidad");

                entity.Property(e => e.IntitonumeroTo)
                    .HasColumnName("intitonumero_to")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VaritoreferenciaProducto)
                    .HasColumnName("varitoreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbllineas>(entity =>
            {
                entity.HasKey(e => e.Intcodigo)
                    .HasName("PK__tbllinea__CC0F1ED85560B5BA");

                entity.ToTable("tbllineas");

                entity.Property(e => e.Intcodigo)
                    .HasColumnName("intcodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intlineas)
                    .HasColumnName("intlineas")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Vardescripcion)
                    .HasColumnName("vardescripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblmaquina>(entity =>
            {
                entity.HasKey(e => e.Intmaqconsecutivo)
                    .HasName("PK__tblmaqui__10E99FCF91E905E3");

                entity.ToTable("tblmaquina");

                entity.Property(e => e.Intmaqconsecutivo)
                    .HasColumnName("intmaqconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Varmaqcodigo)
                    .IsRequired()
                    .HasColumnName("varmaqcodigo")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Varmaqdescripcion)
                    .HasColumnName("varmaqdescripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varmaqmarca)
                    .HasColumnName("varmaqmarca")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblmateriaPrima>(entity =>
            {
                entity.HasKey(e => new { e.Intmpconsecutivo, e.Varmpreferencia })
                    .HasName("PK__tblmater__3880AB02A91BA3C7");

                entity.ToTable("tblmateria_prima");

                entity.Property(e => e.Intmpconsecutivo).HasColumnName("intmpconsecutivo");

                entity.Property(e => e.Varmpreferencia)
                    .HasColumnName("varmpreferencia")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Flompancho).HasColumnName("flompancho");

                entity.Property(e => e.Flompcantidad).HasColumnName("flompcantidad");

                entity.Property(e => e.FlompcostoUnidad).HasColumnName("flompcosto_unidad");

                entity.Property(e => e.Flompdescuento).HasColumnName("flompdescuento");

                entity.Property(e => e.Flompespesor).HasColumnName("flompespesor");

                entity.Property(e => e.Flomplargo).HasColumnName("flomplargo");

                entity.Property(e => e.Flompotro).HasColumnName("flompotro");

                entity.Property(e => e.FlompprecioVentan).HasColumnName("flompprecio_ventan");

                entity.Property(e => e.FlompprecioVentav).HasColumnName("flompprecio_ventav");

                entity.Property(e => e.FlomppuntoMaximo).HasColumnName("flomppunto_maximo");

                entity.Property(e => e.FlomppuntoMinimo).HasColumnName("flomppunto_minimo");

                entity.Property(e => e.IntmpautoLiberable)
                    .HasColumnName("intmpauto_liberable")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intmpestado)
                    .HasColumnName("intmpestado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intmplinea)
                    .HasColumnName("intmplinea")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VarmpdensidadKgUn)
                    .HasColumnName("varmpdensidadKgUn")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmpdescripcion)
                    .HasColumnName("varmpdescripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarmpdocumentoOPlano)
                    .HasColumnName("varmpdocumento_o_plano")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmpevaluador)
                    .HasColumnName("varmpevaluador")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VarmpfechaAprobaGuia)
                    .HasColumnName("varmpfecha_aproba_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarmpfechaAprobaPatron)
                    .HasColumnName("varmpfecha_aproba_patron")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarmpfechaAprobaPlano)
                    .HasColumnName("varmpfecha_aproba_plano")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmpguia)
                    .HasColumnName("varmpguia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmppatron)
                    .HasColumnName("varmppatron")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmptipo)
                    .HasColumnName("varmptipo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VarmpunidadMedida)
                    .HasColumnName("varmpunidad_medida")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VarmpusoGuia)
                    .HasColumnName("varmpuso_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblmaterialesAjuste>(entity =>
            {
                entity.HasKey(e => e.Intmajconsecutivo)
                    .HasName("PK__tblmater__6D97CBA56460E149");

                entity.ToTable("tblmateriales_ajuste");

                entity.Property(e => e.Intmajconsecutivo)
                    .HasColumnName("intmajconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flomajcantidad).HasColumnName("flomajcantidad");

                entity.Property(e => e.Intmajacept)
                    .HasColumnName("intmajacept")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intmajen1)
                    .HasColumnName("intmajen1")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intmajnumero)
                    .HasColumnName("intmajnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varmajen)
                    .HasColumnName("varmajen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varmajen2)
                    .HasColumnName("varmajen2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varmajobservaciones)
                    .HasColumnName("varmajobservaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varmajproducto)
                    .HasColumnName("varmajproducto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmajtipo)
                    .HasColumnName("varmajtipo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Varmajtipo1)
                    .HasColumnName("varmajtipo1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Varmajunidad)
                    .HasColumnName("varmajunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblmaterialesPlanta>(entity =>
            {
                entity.HasKey(e => e.Intmapconsecutivo)
                    .HasName("PK__tblmater__9930D0B5F73D8EF9");

                entity.ToTable("tblmateriales_planta");

                entity.Property(e => e.Intmapconsecutivo)
                    .HasColumnName("intmapconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flomapcantidad).HasColumnName("flomapcantidad");

                entity.Property(e => e.Intmapnumero)
                    .HasColumnName("intmapnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varmapobservaciones)
                    .HasColumnName("varmapobservaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varmapoperario)
                    .HasColumnName("varmapoperario")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmapproducto)
                    .HasColumnName("varmapproducto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblmaterialesRemision>(entity =>
            {
                entity.HasKey(e => e.Intmrconsecutivo)
                    .HasName("PK__tblmater__965385517C19BCEC");

                entity.ToTable("tblmateriales_remision");

                entity.Property(e => e.Intmrconsecutivo)
                    .HasColumnName("intmrconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flomrcantidad).HasColumnName("flomrcantidad");

                entity.Property(e => e.Flomrcosto).HasColumnName("flomrcosto");

                entity.Property(e => e.IntmrnumeroRemision)
                    .HasColumnName("intmrnumero_remision")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intmrnumpat)
                    .HasColumnName("intmrnumpat")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varmrpara)
                    .HasColumnName("varmrpara")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmrpor)
                    .HasColumnName("varmrpor")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarmrreferenciaProducto)
                    .HasColumnName("varmrreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblmaterialesRemision1>(entity =>
            {
                entity.HasKey(e => e.Intmr1consecutivo)
                    .HasName("PK__tblmater__00DD33F5FCCFD913");

                entity.ToTable("tblmateriales_remision1");

                entity.Property(e => e.Intmr1consecutivo)
                    .HasColumnName("intmr1consecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flomr1cantidad).HasColumnName("flomr1cantidad");

                entity.Property(e => e.Intmr1numero)
                    .HasColumnName("intmr1numero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varmr1observaciones)
                    .HasColumnName("varmr1observaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varmr1producto)
                    .HasColumnName("varmr1producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmr1proveedor)
                    .HasColumnName("varmr1proveedor")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblmotivoDevolucion>(entity =>
            {
                entity.HasKey(e => e.Intmdconsecutivo)
                    .HasName("PK__tblmotiv__C14C00AA2DC197A8");

                entity.ToTable("tblmotivo_devolucion");

                entity.Property(e => e.Intmdconsecutivo)
                    .HasColumnName("intmdconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Intmdcodigo)
                    .HasColumnName("intmdcodigo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varmddescripcion)
                    .HasColumnName("varmddescripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblmovimiento>(entity =>
            {
                entity.HasKey(e => e.Intmovconsecutivo)
                    .HasName("PK__tblmovim__8FA65D7BA880DB00");

                entity.ToTable("tblmovimiento");

                entity.Property(e => e.Intmovconsecutivo)
                    .HasColumnName("intmovconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datmovfecha)
                    .HasColumnName("datmovfecha")
                    .HasColumnType("date");

                entity.Property(e => e.Flomovcantidad).HasColumnName("flomovcantidad");

                entity.Property(e => e.Flomovcantidad1).HasColumnName("flomovcantidad1");

                entity.Property(e => e.Flomovcantidad2).HasColumnName("flomovcantidad2");

                entity.Property(e => e.IntmovnumeroPatenta)
                    .HasColumnName("intmovnumero_patenta")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varmovafecta)
                    .HasColumnName("varmovafecta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Varmovde)
                    .HasColumnName("varmovde")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Varmovpara)
                    .HasColumnName("varmovpara")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarmovrealizadoPor)
                    .HasColumnName("varmovrealizado_por")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Varmovrecibio)
                    .HasColumnName("varmovrecibio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarmovreferenciaProducto)
                    .HasColumnName("varmovreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarmovresponsableMovimiento)
                    .HasColumnName("varmovresponsable_movimiento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varmovtipo)
                    .HasColumnName("varmovtipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarmovtipoReferencia)
                    .HasColumnName("varmovtipo_referencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varmovunidad)
                    .HasColumnName("varmovunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblnovedades>(entity =>
            {
                entity.HasKey(e => e.Intnovconsecutivo)
                    .HasName("PK__tblnoved__EB0206A0F0DD8EC3");

                entity.ToTable("tblnovedades");

                entity.Property(e => e.Intnovconsecutivo)
                    .HasColumnName("intnovconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Datnovfecha)
                    .HasColumnName("datnovfecha")
                    .HasColumnType("date");

                entity.Property(e => e.Timnovhora).HasColumnName("timnovhora");

                entity.Property(e => e.Varnovafecta)
                    .HasColumnName("varnovafecta")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VarnovdebidaA)
                    .HasColumnName("varnovdebida_a")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varnovnovedad)
                    .HasColumnName("varnovnovedad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VarnovrealizadaPor)
                    .HasColumnName("varnovrealizada_por")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbloperario>(entity =>
            {
                entity.HasKey(e => new { e.Intopecodigo, e.Varopeinicial })
                    .HasName("PK__tblopera__60534266EA2200AD");

                entity.ToTable("tbloperario");

                entity.Property(e => e.Intopecodigo).HasColumnName("intopecodigo");

                entity.Property(e => e.Varopeinicial)
                    .HasColumnName("varopeinicial")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DatopefechaIngreso)
                    .HasColumnName("datopefecha_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.FloopesalarioHora).HasColumnName("floopesalario_hora");

                entity.Property(e => e.Intopeestado)
                    .HasColumnName("intopeestado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varopeapellido)
                    .HasColumnName("varopeapellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varopenombre)
                    .HasColumnName("varopenombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblordenCompra>(entity =>
            {
                entity.HasKey(e => e.Intocnumero)
                    .HasName("PK__tblorden__00A200C3BF3C0B78");

                entity.ToTable("tblorden_compra");

                entity.Property(e => e.Intocnumero)
                    .HasColumnName("intocnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Datocfecha)
                    .HasColumnName("datocfecha")
                    .HasColumnType("date");

                entity.Property(e => e.DatocfechaEvaluacion)
                    .HasColumnName("datocfecha_evaluacion")
                    .HasColumnType("date");

                entity.Property(e => e.Datocfechaeval)
                    .HasColumnName("datocfechaeval")
                    .HasColumnType("date");

                entity.Property(e => e.Floocevalcalidad).HasColumnName("floocevalcalidad");

                entity.Property(e => e.Floocevalcantidad).HasColumnName("floocevalcantidad");

                entity.Property(e => e.Floocevaltiempo).HasColumnName("floocevaltiempo");

                entity.Property(e => e.FloocevaluacionCalidad).HasColumnName("floocevaluacion_calidad");

                entity.Property(e => e.FloocevaluacionCantidad).HasColumnName("floocevaluacion_cantidad");

                entity.Property(e => e.FloocevaluacionTiempo).HasColumnName("floocevaluacion_tiempo");

                entity.Property(e => e.Floocporcalidad).HasColumnName("floocporcalidad");

                entity.Property(e => e.Floocporcantidad).HasColumnName("floocporcantidad");

                entity.Property(e => e.FloocporcentajeEvaluacionCalidad).HasColumnName("floocporcentaje_evaluacion_calidad");

                entity.Property(e => e.FloocporcentajeEvaluacionCantidad).HasColumnName("floocporcentaje_evaluacion_cantidad");

                entity.Property(e => e.FloocporcentajeEvaluacionTiempo).HasColumnName("floocporcentaje_evaluacion_tiempo");

                entity.Property(e => e.Floocportiempo).HasColumnName("floocportiempo");

                entity.Property(e => e.Intocabierta)
                    .HasColumnName("intocabierta")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intocanulada)
                    .HasColumnName("intocanulada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intocasociada)
                    .HasColumnName("intocasociada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntocatencionCompra)
                    .HasColumnName("intocatencion_compra")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntocevaluacionAtencion)
                    .HasColumnName("intocevaluacion_atencion")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intocliberada)
                    .HasColumnName("intocliberada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intocpagada)
                    .HasColumnName("intocpagada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intocproveedor)
                    .HasColumnName("intocproveedor")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intocrecibida)
                    .HasColumnName("intocrecibida")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intocterminada)
                    .HasColumnName("intocterminada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intoctipo)
                    .HasColumnName("intoctipo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varoccondiciones)
                    .HasColumnName("varoccondiciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varocobservaciones)
                    .HasColumnName("varocobservaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VarocrazonSocialProveedor)
                    .HasColumnName("varocrazon_social_proveedor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varoctipo)
                    .HasColumnName("varoctipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblordenProduccion>(entity =>
            {
                entity.HasKey(e => e.Intopnumero)
                    .HasName("PK__tblorden__89585C412AB751A1");

                entity.ToTable("tblorden_produccion");

                entity.Property(e => e.Intopnumero)
                    .HasColumnName("intopnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Datopfecha)
                    .HasColumnName("datopfecha")
                    .HasColumnType("date");

                entity.Property(e => e.DatopfechaAnulacion)
                    .HasColumnName("datopfecha_anulacion")
                    .HasColumnType("date");

                entity.Property(e => e.DatopfechaGeneracion)
                    .HasColumnName("datopfecha_generacion")
                    .HasColumnType("date");

                entity.Property(e => e.DatopfechaTermino)
                    .HasColumnName("datopfecha_termino")
                    .HasColumnType("date");

                entity.Property(e => e.FloopcantidadInspeccionar).HasColumnName("floopcantidad_inspeccionar");

                entity.Property(e => e.FloopcostoUnidad).HasColumnName("floopcosto_unidad");

                entity.Property(e => e.Floopduracion).HasColumnName("floopduracion");

                entity.Property(e => e.Intopabierta)
                    .HasColumnName("intopabierta")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intopanulada)
                    .HasColumnName("intopanulada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intopcantidad)
                    .HasColumnName("intopcantidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intopcantidad1)
                    .HasColumnName("intopcantidad1")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntopcantidadAdelantada)
                    .HasColumnName("intopcantidad_adelantada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntopcantidadConforme)
                    .HasColumnName("intopcantidad_conforme")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntopcantidadNoConforme)
                    .HasColumnName("intopcantidad_no_conforme")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntopcantidadOrdenada)
                    .HasColumnName("intopcantidad_ordenada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intopcantidadr)
                    .HasColumnName("intopcantidadr")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intopliberada)
                    .HasColumnName("intopliberada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intoprealizada)
                    .HasColumnName("intoprealizada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intopterminada)
                    .HasColumnName("intopterminada")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VaropfechasActualizacion)
                    .HasColumnName("varopfechas_actualizacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VaropfechasLiberacion)
                    .HasColumnName("varopfechas_liberacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varopnotas)
                    .HasColumnName("varopnotas")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varopobservaciones)
                    .HasColumnName("varopobservaciones")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varopobservaciones1)
                    .HasColumnName("varopobservaciones1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VaropreferenciaProducto)
                    .HasColumnName("varopreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaropresponsableAnulacion)
                    .HasColumnName("varopresponsable_anulacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaropresponsableGeneracion)
                    .HasColumnName("varopresponsable_generacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VaropresponsablesActualizacion)
                    .HasColumnName("varopresponsables_actualizacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VaropresponsablesLiberacion)
                    .HasColumnName("varopresponsables_liberacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblpadre>(entity =>
            {
                entity.HasKey(e => new { e.VarpadreferenciaProducto, e.VarpadreferenciaPadre })
                    .HasName("PK__tblpadre__566DA64266B09C46");

                entity.ToTable("tblpadre");

                entity.Property(e => e.VarpadreferenciaProducto)
                    .HasColumnName("varpadreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VarpadreferenciaPadre)
                    .HasColumnName("varpadreferencia_padre")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Flopadcantidad).HasColumnName("flopadcantidad");

                entity.Property(e => e.Flopadcosto).HasColumnName("flopadcosto");

                entity.Property(e => e.Flopadcosto1).HasColumnName("flopadcosto1");

                entity.Property(e => e.Varpadtipo)
                    .IsRequired()
                    .HasColumnName("varpadtipo")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Varpadtipo1)
                    .HasColumnName("varpadtipo1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpadunidad)
                    .HasColumnName("varpadunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblpais>(entity =>
            {
                entity.HasKey(e => e.Intpaicodigo)
                    .HasName("PK__tblpais__89598B35A4704636");

                entity.ToTable("tblpais");

                entity.Property(e => e.Intpaicodigo)
                    .HasColumnName("intpaicodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Varpainombre)
                    .HasColumnName("varpainombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblplanta>(entity =>
            {
                entity.HasKey(e => e.Intplconsecutivo)
                    .HasName("PK__tblplant__3DFA2B00ECE3C177");

                entity.ToTable("tblplanta");

                entity.Property(e => e.Intplconsecutivo)
                    .HasColumnName("intplconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Floplcantidad).HasColumnName("floplcantidad");

                entity.Property(e => e.Floplcantidad1).HasColumnName("floplcantidad1");

                entity.Property(e => e.VarplreferenciaProducto)
                    .HasColumnName("varplreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarpltipoReferencia)
                    .HasColumnName("varpltipo_referencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varplunidad)
                    .HasColumnName("varplunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblprocesoMaquina>(entity =>
            {
                entity.HasKey(e => new { e.IntpmcodigoProceso, e.IntpmconseMaquina })
                    .HasName("PK__tblproce__D381AA64785777DF");

                entity.ToTable("tblproceso_maquina");

                entity.Property(e => e.IntpmcodigoProceso)
                    .HasColumnName("intpmcodigo_proceso")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpmconseMaquina)
                    .HasColumnName("intpmconse_maquina")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TblprocesoOperario>(entity =>
            {
                entity.HasKey(e => new { e.IntpocodigoProceso, e.IntpocodigoOperario, e.IntponumeroOrden, e.Intpotipo })
                    .HasName("PK__tblproce__3C0117413BA603C1");

                entity.ToTable("tblproceso_operario");

                entity.Property(e => e.IntpocodigoProceso)
                    .HasColumnName("intpocodigo_proceso")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpocodigoOperario)
                    .HasColumnName("intpocodigo_operario")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntponumeroOrden)
                    .HasColumnName("intponumero_orden")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intpotipo)
                    .HasColumnName("intpotipo")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TblprocesoProducto>(entity =>
            {
                entity.HasKey(e => new { e.IntppptcodigoProceso, e.VarppptreferenciaProducto })
                    .HasName("PK__tblproce__E932001C02569BAC");

                entity.ToTable("tblproceso_producto");

                entity.Property(e => e.IntppptcodigoProceso)
                    .HasColumnName("intppptcodigo_proceso")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VarppptreferenciaProducto)
                    .HasColumnName("varppptreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Intppptorden)
                    .HasColumnName("intppptorden")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Tblprocesoe>(entity =>
            {
                entity.HasKey(e => new { e.Intproecodigo, e.Varproedescripcion })
                    .HasName("PK__tblproce__2F48ADF44D659BC1");

                entity.ToTable("tblprocesoe");

                entity.Property(e => e.Intproecodigo).HasColumnName("intproecodigo");

                entity.Property(e => e.Varproedescripcion)
                    .HasColumnName("varproedescripcion")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IntproecodigoTipo)
                    .HasColumnName("intproecodigo_tipo")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TblproductoProceso>(entity =>
            {
                entity.HasKey(e => new { e.Intppconsecutivo, e.Varppreferencia })
                    .HasName("PK__tblprodu__C65C92F1248059CD");

                entity.ToTable("tblproducto_proceso");

                entity.Property(e => e.Intppconsecutivo).HasColumnName("intppconsecutivo");

                entity.Property(e => e.Varppreferencia)
                    .HasColumnName("varppreferencia")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DatppfechaActcompo)
                    .HasColumnName("datppfecha_actcompo")
                    .HasColumnType("date");

                entity.Property(e => e.DatppfechaActproces)
                    .HasColumnName("datppfecha_actproces")
                    .HasColumnType("date");

                entity.Property(e => e.Floppancho).HasColumnName("floppancho");

                entity.Property(e => e.Floppcantidad).HasColumnName("floppcantidad");

                entity.Property(e => e.Floppcosto).HasColumnName("floppcosto");

                entity.Property(e => e.Floppdescuento).HasColumnName("floppdescuento");

                entity.Property(e => e.Flopplargo).HasColumnName("flopplargo");

                entity.Property(e => e.FloppprecioVentan).HasColumnName("floppprecio_ventan");

                entity.Property(e => e.FloppprecioVentav).HasColumnName("floppprecio_ventav");

                entity.Property(e => e.FlopppuntoMaximo).HasColumnName("flopppunto_maximo");

                entity.Property(e => e.FlopppuntoMinimo).HasColumnName("flopppunto_minimo");

                entity.Property(e => e.Floppservicio).HasColumnName("floppservicio");

                entity.Property(e => e.IntppautoLiberable)
                    .HasColumnName("intppauto_liberable")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intppestado)
                    .HasColumnName("intppestado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intpplinea)
                    .HasColumnName("intpplinea")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VarppdensidadKgUn)
                    .HasColumnName("varppdensidadKgUn")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varppdescripcion)
                    .HasColumnName("varppdescripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarppdocumentoOPlano)
                    .HasColumnName("varppdocumento_o_plano")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarppfechaAprobaGuia)
                    .HasColumnName("varppfecha_aproba_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarppfechaAprobaPatron)
                    .HasColumnName("varppfecha_aproba_patron")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarppfechaAprobaPlano)
                    .HasColumnName("varppfecha_aproba_plano")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varppguia)
                    .HasColumnName("varppguia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varpppatron)
                    .HasColumnName("varpppatron")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varpptipo)
                    .HasColumnName("varpptipo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VarppunidadMedida)
                    .HasColumnName("varppunidad_medida")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VarppusoGuia)
                    .HasColumnName("varppuso_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblproductoTerminado>(entity =>
            {
                entity.HasKey(e => new { e.Intptconsecutivo, e.Varptreferencia })
                    .HasName("PK__tblprodu__A2841874062F1A23");

                entity.ToTable("tblproducto_terminado");

                entity.Property(e => e.Intptconsecutivo).HasColumnName("intptconsecutivo");

                entity.Property(e => e.Varptreferencia)
                    .HasColumnName("varptreferencia")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DatptfechaActcompo)
                    .HasColumnName("datptfecha_actcompo")
                    .HasColumnType("date");

                entity.Property(e => e.DatptfechaActproces)
                    .HasColumnName("datptfecha_actproces")
                    .HasColumnType("date");

                entity.Property(e => e.Floptcantidad).HasColumnName("floptcantidad");

                entity.Property(e => e.Floptcosto).HasColumnName("floptcosto");

                entity.Property(e => e.Floptdescuento).HasColumnName("floptdescuento");

                entity.Property(e => e.FloptprecioVentan).HasColumnName("floptprecio_ventan");

                entity.Property(e => e.FloptprecioVentav).HasColumnName("floptprecio_ventav");

                entity.Property(e => e.FloptpuntoMaximo).HasColumnName("floptpunto_maximo");

                entity.Property(e => e.FloptpuntoMinimo).HasColumnName("floptpunto_minimo");

                entity.Property(e => e.IntptautoLiberable)
                    .HasColumnName("intptauto_liberable")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intptlinea)
                    .HasColumnName("intptlinea")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.VarptdensidadKgUn)
                    .HasColumnName("varptdensidadKgUn")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varptdescripcion)
                    .HasColumnName("varptdescripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VarptdocumentoOPlano)
                    .HasColumnName("varptdocumento_o_plano")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarptfechaAprobaGuia)
                    .HasColumnName("varptfecha_aproba_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarptfechaAprobaPatron)
                    .HasColumnName("varptfecha_aproba_patron")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarptfechaAprobaPlano)
                    .HasColumnName("varptfecha_aproba_plano")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varptguia)
                    .HasColumnName("varptguia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varptpatron)
                    .HasColumnName("varptpatron")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarptunidadMedida)
                    .HasColumnName("varptunidad_medida")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VarptusoGuia)
                    .HasColumnName("varptuso_guia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblproductosCliente>(entity =>
            {
                entity.HasKey(e => e.Intpctconsecutivo)
                    .HasName("PK__tblprodu__CEF50F33E3389817");

                entity.ToTable("tblproductos_cliente");

                entity.Property(e => e.Intpctconsecutivo)
                    .HasColumnName("intpctconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flopctcantidad).HasColumnName("flopctcantidad");

                entity.Property(e => e.Intpctnumero)
                    .HasColumnName("intpctnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varpctcliente)
                    .HasColumnName("varpctcliente")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varpctobservaciones)
                    .HasColumnName("varpctobservaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varpctpor)
                    .HasColumnName("varpctpor")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varpctproducto)
                    .HasColumnName("varpctproducto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblproveedor>(entity =>
            {
                entity.HasKey(e => e.Intpvconsecutivo)
                    .HasName("PK__tblprove__3DAAA6F85874B1A4");

                entity.ToTable("tblproveedor");

                entity.Property(e => e.Intpvconsecutivo)
                    .HasColumnName("intpvconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flopvcantidad).HasColumnName("flopvcantidad");

                entity.Property(e => e.Flopvcantidad1).HasColumnName("flopvcantidad1");

                entity.Property(e => e.Varpvpermilib)
                    .HasColumnName("varpvpermilib")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VarpvrazonSocial)
                    .HasColumnName("varpvrazon_social")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VarpvreferenciaProducto)
                    .HasColumnName("varpvreferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarpvtipoReferencia)
                    .HasColumnName("varpvtipo_referencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpvunidad)
                    .HasColumnName("varpvunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblproveedormp>(entity =>
            {
                entity.HasKey(e => e.Intpmpcodigo)
                    .HasName("PK__tblprove__01A76AEAD0FD07FD");

                entity.ToTable("tblproveedormp");

                entity.Property(e => e.Intpmpcodigo)
                    .HasColumnName("intpmpcodigo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DatpmpfechaEvaluacion)
                    .HasColumnName("datpmpfecha_evaluacion")
                    .HasColumnType("date");

                entity.Property(e => e.DatpmpfechaIngreso)
                    .HasColumnName("datpmpfecha_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.Flopmpdescuento).HasColumnName("flopmpdescuento");

                entity.Property(e => e.Flopmpevaluacion).HasColumnName("flopmpevaluacion");

                entity.Property(e => e.Intpmpciudad)
                    .HasColumnName("intpmpciudad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpmpcontroladoCalidad)
                    .HasColumnName("intpmpcontrolado_calidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intpmpestado)
                    .HasColumnName("intpmpestado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intpmpplazo)
                    .HasColumnName("intpmpplazo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpmptiempoEntrega)
                    .HasColumnName("intpmptiempo_entrega")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpmptipoCalidad)
                    .HasColumnName("intpmptipo_calidad")
                    .HasDefaultValueSql("('3')");

                entity.Property(e => e.Varpmpactualizaciones)
                    .HasColumnName("varpmpactualizaciones")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpciudad)
                    .HasColumnName("varpmpciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpcontacto)
                    .HasColumnName("varpmpcontacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpde)
                    .HasColumnName("varpmpde")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpdireccion)
                    .HasColumnName("varpmpdireccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpemail)
                    .HasColumnName("varpmpemail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarpmpevaluacionesCalidad)
                    .HasColumnName("varpmpevaluaciones_calidad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpfax)
                    .HasColumnName("varpmpfax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpnit)
                    .HasColumnName("varpmpnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmpproducto)
                    .HasColumnName("varpmpproducto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarpmpquienRealiza)
                    .HasColumnName("varpmpquien_realiza")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarpmprazonSocial)
                    .HasColumnName("varpmprazon_social")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varpmptelefono)
                    .HasColumnName("varpmptelefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblproveedors>(entity =>
            {
                entity.HasKey(e => e.Intpscodigo)
                    .HasName("PK__tblprove__AAEE78FEA0CEC351");

                entity.ToTable("tblproveedors");

                entity.Property(e => e.Intpscodigo)
                    .HasColumnName("intpscodigo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DatpsfechaEvaluacion)
                    .HasColumnName("datpsfecha_evaluacion")
                    .HasColumnType("date");

                entity.Property(e => e.DatpsfechaIngreso)
                    .HasColumnName("datpsfecha_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.Flopsdescuento).HasColumnName("flopsdescuento");

                entity.Property(e => e.Flopsevaluacion).HasColumnName("flopsevaluacion");

                entity.Property(e => e.Intpsciudad)
                    .HasColumnName("intpsciudad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpscontroladoCalidad)
                    .HasColumnName("intpscontrolado_calidad")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intpsestado)
                    .HasColumnName("intpsestado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intpsplazo)
                    .HasColumnName("intpsplazo")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpstiempoEntrega)
                    .HasColumnName("intpstiempo_entrega")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntpstipoCalidad)
                    .HasColumnName("intpstipo_calidad")
                    .HasDefaultValueSql("('3')");

                entity.Property(e => e.Varpsactualizaciones)
                    .HasColumnName("varpsactualizaciones")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varpsciudad)
                    .HasColumnName("varpsciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpscontacto)
                    .HasColumnName("varpscontacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpsde)
                    .HasColumnName("varpsde")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpsdireccion)
                    .HasColumnName("varpsdireccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpsemail)
                    .HasColumnName("varpsemail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarpsevaluacionesCalidad)
                    .HasColumnName("varpsevaluaciones_calidad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Varpsfax)
                    .HasColumnName("varpsfax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpsnit)
                    .HasColumnName("varpsnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varpsproducto)
                    .HasColumnName("varpsproducto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarpsquienRealiza)
                    .HasColumnName("varpsquien_realiza")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarpsrazonSocial)
                    .HasColumnName("varpsrazon_social")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varpstelefono)
                    .HasColumnName("varpstelefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblrecepcionPlanta>(entity =>
            {
                entity.HasKey(e => e.Intrpconsecutivo)
                    .HasName("PK__tblrecep__27C25FD64CBBC44B");

                entity.ToTable("tblrecepcion_planta");

                entity.Property(e => e.Intrpconsecutivo)
                    .HasColumnName("intrpconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntrpcantidadPosibleRecibir)
                    .HasColumnName("intrpcantidad_posible_recibir")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IntrpcantidadRecibida)
                    .HasColumnName("intrpcantidad_recibida")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intrpnumero)
                    .HasColumnName("intrpnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varrpforma)
                    .HasColumnName("varrpforma")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varrpobservaciones)
                    .HasColumnName("varrpobservaciones")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarrpoperarioEntrega)
                    .HasColumnName("varrpoperario_entrega")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varrpreferencia)
                    .HasColumnName("varrpreferencia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblrecepcionProveedors>(entity =>
            {
                entity.HasKey(e => e.Intrpsnumero)
                    .HasName("PK__tblrecep__26C76A437338916C");

                entity.ToTable("tblrecepcion_proveedors");

                entity.Property(e => e.Intrpsnumero)
                    .HasColumnName("intrpsnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Datrpsfecha)
                    .HasColumnName("datrpsfecha")
                    .HasColumnType("date");

                entity.Property(e => e.Intrpsproveedor)
                    .HasColumnName("intrpsproveedor")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varrpsobservaciones)
                    .HasColumnName("varrpsobservaciones")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblrecmatpvs>(entity =>
            {
                entity.HasKey(e => e.Intspconsecutivo)
                    .HasName("PK__tblrecma__9B04CB4F73C2642D");

                entity.ToTable("tblrecmatpvs");

                entity.Property(e => e.Intspconsecutivo)
                    .HasColumnName("intspconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flospcantidad).HasColumnName("flospcantidad");

                entity.Property(e => e.Flospcantidad1).HasColumnName("flospcantidad1");

                entity.Property(e => e.Varspobservaciones)
                    .HasColumnName("varspobservaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varspproducto)
                    .HasColumnName("varspproducto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Varspproveedor)
                    .HasColumnName("varspproveedor")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblremision>(entity =>
            {
                entity.HasKey(e => e.Intremnumero)
                    .HasName("PK__tblremis__4BA122292DC0A615");

                entity.ToTable("tblremision");

                entity.Property(e => e.Intremnumero)
                    .HasColumnName("intremnumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Datremfecha)
                    .HasColumnName("datremfecha")
                    .HasColumnType("date");

                entity.Property(e => e.Intremnumpat)
                    .HasColumnName("intremnumpat")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varremobservaciones)
                    .HasColumnName("varremobservaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varrempara)
                    .HasColumnName("varrempara")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varrempor)
                    .HasColumnName("varrempor")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblremision1>(entity =>
            {
                entity.HasKey(e => e.Intrem1numero)
                    .HasName("PK__tblremis__38B7DBDE0C71CD02");

                entity.ToTable("tblremision1");

                entity.Property(e => e.Intrem1numero)
                    .HasColumnName("intrem1numero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Datrem1fecha)
                    .HasColumnName("datrem1fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Intrem1proveedor)
                    .HasColumnName("intrem1proveedor")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Varrem1observaciones)
                    .HasColumnName("varrem1observaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Varrem1proveedor)
                    .HasColumnName("varrem1proveedor")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblsegOpcionMenu>(entity =>
            {
                entity.HasKey(e => e.Idopcion)
                    .HasName("PK__tblseg_o__8C01E19B3EBF5E8A");

                entity.ToTable("tblseg_opcion_menu");

                entity.Property(e => e.Idopcion).HasColumnName("idopcion");

                entity.Property(e => e.Dtmfecha)
                    .HasColumnName("dtmfecha")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('2000-00-00')");

                entity.Property(e => e.Intidopcion)
                    .HasColumnName("intidopcion")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Intnivel)
                    .HasColumnName("intnivel")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Strdescripcion)
                    .HasColumnName("strdescripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Strlink)
                    .IsRequired()
                    .HasColumnName("strlink")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Strnombre)
                    .IsRequired()
                    .HasColumnName("strnombre")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblsegOpcionMenuant>(entity =>
            {
                entity.HasKey(e => e.Idopcion)
                    .HasName("PK__tblseg_o__8C01E19B625FEFEE");

                entity.ToTable("tblseg_opcion_menuant");

                entity.Property(e => e.Idopcion).HasColumnName("idopcion");

                entity.Property(e => e.Dtmfecha)
                    .HasColumnName("dtmfecha")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('2000-00-00')");

                entity.Property(e => e.Strdescripcion)
                    .HasColumnName("strdescripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Strlink)
                    .IsRequired()
                    .HasColumnName("strlink")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Strnombre)
                    .IsRequired()
                    .HasColumnName("strnombre")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblsegOpcionPerfil>(entity =>
            {
                entity.HasKey(e => new { e.Idperfil, e.Idopcion })
                    .HasName("PK__tblseg_o__AA35195F753E6068");

                entity.ToTable("tblseg_opcion_perfil");

                entity.Property(e => e.Idperfil)
                    .HasColumnName("idperfil")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Idopcion)
                    .HasColumnName("idopcion")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TblsegOpcionPerfilant>(entity =>
            {
                entity.HasKey(e => new { e.Idperfil, e.Idopcion })
                    .HasName("PK__tblseg_o__AA35195FFAE5105B");

                entity.ToTable("tblseg_opcion_perfilant");

                entity.Property(e => e.Idperfil)
                    .HasColumnName("idperfil")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Idopcion)
                    .HasColumnName("idopcion")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TblsegPerfiles>(entity =>
            {
                entity.HasKey(e => e.Idperfil)
                    .HasName("PK__tblseg_p__02F50746C58EB1CB");

                entity.ToTable("tblseg_perfiles");

                entity.Property(e => e.Idperfil).HasColumnName("idperfil");

                entity.Property(e => e.Strdescripcion)
                    .HasColumnName("strdescripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Strnombre)
                    .IsRequired()
                    .HasColumnName("strnombre")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblsegPerfilesant>(entity =>
            {
                entity.HasKey(e => e.Idperfil)
                    .HasName("PK__tblseg_p__02F507465829E1C6");

                entity.ToTable("tblseg_perfilesant");

                entity.Property(e => e.Idperfil).HasColumnName("idperfil");

                entity.Property(e => e.Strdescripcion)
                    .HasColumnName("strdescripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Strnombre)
                    .IsRequired()
                    .HasColumnName("strnombre")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TbltelefonoCliente>(entity =>
            {
                entity.HasKey(e => e.Inttccodigo)
                    .HasName("PK__tbltelef__90F82FF85559FD36");

                entity.ToTable("tbltelefono_cliente");

                entity.Property(e => e.Inttccodigo)
                    .HasColumnName("inttccodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Inttccliente)
                    .HasColumnName("inttccliente")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InttctipoTelefono)
                    .HasColumnName("inttctipo_telefono")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Vartctelefono)
                    .HasColumnName("vartctelefono")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Tbltemp>(entity =>
            {
                entity.HasKey(e => e.Inttmpconsecutivo)
                    .HasName("PK__tbltemp__8909CF557FC2EDE4");

                entity.ToTable("tbltemp");

                entity.Property(e => e.Inttmpconsecutivo)
                    .HasColumnName("inttmpconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flotmpcantidad).HasColumnName("flotmpcantidad");

                entity.Property(e => e.Vartmpproducto)
                    .HasColumnName("vartmpproducto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vartmpproveedor)
                    .HasColumnName("vartmpproveedor")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Tbltemp1>(entity =>
            {
                entity.HasKey(e => e.Inttmpcodigo)
                    .HasName("PK__tbltemp1__4CD539373868172E");

                entity.ToTable("tbltemp1");

                entity.Property(e => e.Inttmpcodigo)
                    .HasColumnName("inttmpcodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Inttmpcodproc).HasColumnName("inttmpcodproc");

                entity.Property(e => e.Vartmpcodmaq)
                    .HasColumnName("vartmpcodmaq")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbltemp2>(entity =>
            {
                entity.HasKey(e => new { e.InttmpnumeroOrden, e.InttmpcodigoProceso })
                    .HasName("PK__tbltemp2__8276EB0BFE7B9199");

                entity.ToTable("tbltemp2");

                entity.Property(e => e.InttmpnumeroOrden)
                    .HasColumnName("inttmpnumero_orden")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.InttmpcodigoProceso)
                    .HasColumnName("inttmpcodigo_proceso")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Flotmpcostomo).HasColumnName("flotmpcostomo");

                entity.Property(e => e.VartmpcodigoOperario)
                    .HasColumnName("vartmpcodigo_operario")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbltemporalGodcs>(entity =>
            {
                entity.HasKey(e => e.Inttgonumero)
                    .HasName("PK__tbltempo__C63474E83B720BF7");

                entity.ToTable("tbltemporal_godcs");

                entity.Property(e => e.Inttgonumero)
                    .HasColumnName("inttgonumero")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TbltemporalGremision>(entity =>
            {
                entity.HasKey(e => e.Inttgrnumero)
                    .HasName("PK__tbltempo__86D814BDE3929F13");

                entity.ToTable("tbltemporal_gremision");

                entity.Property(e => e.Inttgrnumero)
                    .HasColumnName("inttgrnumero")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TbltemporalOds>(entity =>
            {
                entity.HasKey(e => e.Inttonumero)
                    .HasName("PK__tbltempo__9AA8376E82AEC5BF");

                entity.ToTable("tbltemporal_ods");

                entity.Property(e => e.Inttonumero)
                    .HasColumnName("inttonumero")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Inttoproveedor)
                    .HasColumnName("inttoproveedor")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<TbltipoProceso>(entity =>
            {
                entity.HasKey(e => e.Inttpcodigo)
                    .HasName("PK__tbltipo___75269072DE5F8A10");

                entity.ToTable("tbltipo_proceso");

                entity.Property(e => e.Inttpcodigo)
                    .HasColumnName("inttpcodigo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Vartpdescripcion)
                    .HasColumnName("vartpdescripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblusuarios>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__tblusuar__080A97433A101E85");

                entity.ToTable("tblusuarios");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Idperfil)
                    .HasColumnName("idperfil")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Strdescripcion)
                    .HasColumnName("strdescripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Strlogin)
                    .IsRequired()
                    .HasColumnName("strlogin")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Tblusuariosant>(entity =>
            {
                entity.HasKey(e => e.Idusuario)
                    .HasName("PK__tblusuar__080A9743CFFEE2F4");

                entity.ToTable("tblusuariosant");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Idperfil)
                    .HasColumnName("idperfil")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Strdescripcion)
                    .HasColumnName("strdescripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Strlogin)
                    .IsRequired()
                    .HasColumnName("strlogin")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblzonaAmarilla>(entity =>
            {
                entity.HasKey(e => e.Intzaconsecutivo)
                    .HasName("PK__tblzona___14F47F5F2A6A64BB");

                entity.ToTable("tblzona_amarilla");

                entity.Property(e => e.Intzaconsecutivo)
                    .HasColumnName("intzaconsecutivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Flozacantidad).HasColumnName("flozacantidad");

                entity.Property(e => e.VarzareferenciaProducto)
                    .HasColumnName("varzareferencia_producto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.VarzatipoReferencia)
                    .HasColumnName("varzatipo_referencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Varzaunidad)
                    .HasColumnName("varzaunidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
