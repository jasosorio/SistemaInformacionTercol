using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaInformacionTercol.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblalertas",
                columns: table => new
                {
                    intalerconsecutivo = table.Column<int>(nullable: false),
                    varalerdescripcion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intalerbandera = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblalert__4FE08CB1E62F0C21", x => x.intalerconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblciudad",
                columns: table => new
                {
                    intciucodigo = table.Column<int>(nullable: false),
                    intciudepartamento = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varciunombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblciuda__2CEC2C790C8E3CBB", x => x.intciucodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblcliente",
                columns: table => new
                {
                    intclconsecutivo = table.Column<int>(nullable: false),
                    floclcantidad = table.Column<double>(nullable: true),
                    varclreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varclrazon_social = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varcltipo_referencia = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varclunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblclien__9FD8FF9AB433114D", x => x.intclconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblclientet",
                columns: table => new
                {
                    intcltcodigo = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    varcltrazon_social = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varcltnit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varcltdireccion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intcltciudad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varclttelefono = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varcltfax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varcltemail = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varcltcontacto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intcltestado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intcltcontrolado_calidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intclttipo_calidad = table.Column<int>(nullable: true, defaultValueSql: "('3')"),
                    flocltevaluacion = table.Column<double>(nullable: true),
                    datcltfecha_evaluacion = table.Column<DateTime>(type: "date", nullable: true),
                    flocltdescuento = table.Column<double>(nullable: true),
                    intclttiempo_entrega = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intcltplazo = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varcltproducto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varcltevaluaciones_calidad = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varcltactualizaciones = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varcltquien_realiza = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    datcltfecha_ingreso = table.Column<DateTime>(type: "date", nullable: true),
                    flocltdescuentov = table.Column<double>(nullable: true),
                    varcltciudad = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblclien__972621AC5598BDF0", x => x.intcltcodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblconsecutivo_documentos",
                columns: table => new
                {
                    intcdid = table.Column<int>(nullable: false),
                    intcdnumero = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblconse__D55293F892E5ACB6", x => x.intcdid);
                });

            migrationBuilder.CreateTable(
                name: "tblcontacto_cliente",
                columns: table => new
                {
                    intcccodigo = table.Column<int>(nullable: false),
                    intcccliente = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varcccontacto = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblconta__BA714A9C6F1C645C", x => x.intcccodigo);
                });

            migrationBuilder.CreateTable(
                name: "tbldatos_evaluacion",
                columns: table => new
                {
                    intdeconsecutivo = table.Column<int>(nullable: false),
                    intdenodcs = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardeproveedor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    vardereferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flodecantidad_recibida = table.Column<double>(nullable: true),
                    flodecantidad_verificada = table.Column<double>(nullable: true),
                    intdevaltiempo = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdevalcantidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdevalcalidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varderesponsable = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    datdefecha = table.Column<DateTime>(type: "date", nullable: true),
                    flodeportiempo = table.Column<double>(nullable: true),
                    flodeporcantidad = table.Column<double>(nullable: true),
                    flodeporcalidad = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldatos__46D21D0A3E3D6069", x => x.intdeconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tbldatos_procesodp",
                columns: table => new
                {
                    intdpoconsecutivo = table.Column<int>(nullable: false),
                    intdponumero_orden = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpocodigo_proceso = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpocodigo_operario = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    flodpocantidad = table.Column<double>(nullable: true),
                    intdpoinspeccion = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpotermino = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    flodpoduracionh = table.Column<double>(nullable: true),
                    flodpocostouni = table.Column<double>(nullable: true),
                    flodpocostocan = table.Column<double>(nullable: true),
                    datdpofechaini = table.Column<DateTime>(type: "date", nullable: true),
                    datdpofechafin = table.Column<DateTime>(type: "date", nullable: true),
                    timdpohoraini = table.Column<TimeSpan>(nullable: true),
                    timdpohorafin = table.Column<TimeSpan>(nullable: true),
                    intdpopasada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpoayudante = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpoinspeccion1 = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpoalis = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpopasada1 = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdpotermino1 = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldatos__A422EBC59359F11C", x => x.intdpoconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tbldepartamento",
                columns: table => new
                {
                    intdepcodigo = table.Column<int>(nullable: false),
                    intdeppais = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardepnombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldepar__9B89D5F41B880301", x => x.intdepcodigo);
                });

            migrationBuilder.CreateTable(
                name: "tbldescuento_cliente",
                columns: table => new
                {
                    intdeccodigo = table.Column<int>(nullable: false),
                    intdeccliente = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdectipo_descuento = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    flodecdescuento = table.Column<double>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldescu__54847419AA42BB53", x => x.intdeccodigo);
                });

            migrationBuilder.CreateTable(
                name: "tbldesperdicio",
                columns: table => new
                {
                    intdsconsecutivo = table.Column<int>(nullable: false),
                    flodscantidad = table.Column<double>(nullable: true),
                    vardsreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    vardstipo_referencia = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    vardsunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldespe__92C12E272886ABB6", x => x.intdsconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tbldetalle_consecutivo_documentos",
                columns: table => new
                {
                    intdcdnumero_item = table.Column<int>(nullable: false),
                    intdcdnumero_cd = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardcdreferencia_item = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flodcdcantidad_item = table.Column<double>(nullable: true),
                    flodcdcosto_unidad_item = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldetal__6316096F560DB852", x => x.intdcdnumero_item);
                });

            migrationBuilder.CreateTable(
                name: "tbldetalle_documento_recepcion",
                columns: table => new
                {
                    intddrconsecutivo = table.Column<int>(nullable: false),
                    intddrid_documento = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intddritem_documento = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floddrcantidad = table.Column<double>(nullable: true),
                    floddrcantidad_pagada = table.Column<double>(nullable: true),
                    intddrpagado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varddrresponsables_registro_documento = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    varddrfechas_registro_documento = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    varddrresponsables_pago_documento = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    varddrfechas_pago_documento = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldetal__0431F2A22FC00050", x => x.intddrconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tbldetalle_orden_produccion",
                columns: table => new
                {
                    intdoconsecutivo = table.Column<int>(nullable: false),
                    intdonumero_orden = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    intdocodigo_proceso = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    datdofecha_proceso = table.Column<DateTime>(type: "date", nullable: true),
                    vardocodigo_maquina = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    flododuracion_proceso = table.Column<double>(nullable: true),
                    intdocantidad_conforme = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardocodigo_operario = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    flodocoscan = table.Column<double>(nullable: true),
                    flodocosuni = table.Column<double>(nullable: true),
                    intdoinspeccion = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdoinspeccion1 = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardoalistador = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldetal__7AF7CD45D524FFA8", x => new { x.intdoconsecutivo, x.intdonumero_orden, x.intdocodigo_proceso });
                });

            migrationBuilder.CreateTable(
                name: "tbldevolucion_noconforme",
                columns: table => new
                {
                    intdncnumero = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    datdncfecha_nc = table.Column<DateTime>(type: "date", nullable: true),
                    flodnccantidad_nc = table.Column<double>(nullable: true),
                    flodncpesok_cantidad_nc = table.Column<double>(nullable: true),
                    intdncnumero_odp_detecto = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardncproceso_odp_detecto = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    flodnccantidad_ordenada_odp_detecto = table.Column<double>(nullable: true),
                    vardncreferencia_odp_detecto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    vardncoperario_detecto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    intdnccodigo_motivo_nc = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdnccodigo_debidoa = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardncreferencia_nc = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    intdncnumero_odp_nc = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdnccodigo_proceso_nc = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardncoperarios_nc = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    vardncmaquinas_nc = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    vardncproceso_nc = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    timdnchora_nc = table.Column<TimeSpan>(nullable: true),
                    flodnccantidad_nc_porsolucionar = table.Column<double>(nullable: true),
                    vardnccantidad_nc_solucionada = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intdncnc_solucionada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardncsolucion_dada_nc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    vardncoperarios_solucionaron_nc = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intdncestado_odp_detecto = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    flodnccantidad_nc_reprocesada = table.Column<double>(nullable: true),
                    flodnccantidad_nc_reclasificada = table.Column<double>(nullable: true),
                    flodnccantidad_nc_derogada = table.Column<double>(nullable: true),
                    flodnccantidad_nc_desperdiciada = table.Column<double>(nullable: true),
                    vardncdescripcion_referencia_odp_detecto = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    intdnccodigo_proceso_odp_detecto = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdnccodigo_operario_detecto = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardncdescripcion_referencia_nc = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    vardncmotivo_nc = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    vardncalistador_registro_nc = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    vardncreferencias_enviadas_za = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    vardnccantidad_referencias_enviadas_za = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    intdncnumero_referencias_enviadas_za = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardncalistadores_nc = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldevol__C298412834179412", x => x.intdncnumero);
                });

            migrationBuilder.CreateTable(
                name: "tbldireccion_cliente",
                columns: table => new
                {
                    intdccodigo = table.Column<int>(nullable: false),
                    intdccliente = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdcciudad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardcdireccion = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldirec__D3CAFE9DAE20F165", x => x.intdccodigo);
                });

            migrationBuilder.CreateTable(
                name: "tbldocumento_recepcion",
                columns: table => new
                {
                    intdrconsecutivo = table.Column<int>(nullable: false),
                    intdrtipo_documento = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vardrnumero_documento = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intdrtipo_orden = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdrproveedor = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intdrpagado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    datdrfecha_generacion = table.Column<DateTime>(type: "date", nullable: true),
                    vardrresponsables_registro = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    vardrfechas_registro = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    datdrfecha_pago = table.Column<DateTime>(type: "date", nullable: true),
                    vardrresponsables_pago = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    vardrfechas_pago = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    intdrnumero_documento = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbldocum__7E11C954031646DC", x => x.intdrconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblemail_cliente",
                columns: table => new
                {
                    inteccodigo = table.Column<int>(nullable: false),
                    inteccliente = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varecemail = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblemail__055FC49D8DB63287", x => x.inteccodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblevaluacion_odcs",
                columns: table => new
                {
                    inteoconsecutivo = table.Column<int>(nullable: false),
                    dateofecha_evaluacion = table.Column<DateTime>(type: "date", nullable: true),
                    inteonumero_orden = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    inteoitem_orden = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floeocantidad_recibida = table.Column<double>(nullable: true),
                    floeocantidad_verificada = table.Column<double>(nullable: true),
                    inteoevaluacion_tiempo = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    inteoevaluacion_calidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    inteoevaluacion_cantidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floeoporcentaje_evaluacion_tiempo = table.Column<double>(nullable: true),
                    floeoporcentaje_evaluacion_calidad = table.Column<double>(nullable: true),
                    floeoporcentaje_evaluacion_cantidad = table.Column<double>(nullable: true),
                    vareoresponsable_evaluacion = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblevalu__0A17340DE7DEE75E", x => x.inteoconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblitems_odc",
                columns: table => new
                {
                    intiodcconsecutivo = table.Column<int>(nullable: false),
                    intiodcnumero_odc = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    variodcreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floiodccantidad_ordenada = table.Column<double>(nullable: true),
                    floiodccosto_unitario = table.Column<double>(nullable: true),
                    floiodccantidad_recibida = table.Column<double>(nullable: true),
                    floiodccantidad_verificada = table.Column<double>(nullable: true),
                    floiodcevaluacion_tiempo = table.Column<double>(nullable: true),
                    floiodcevaluacion_calidad = table.Column<double>(nullable: true),
                    floiodcevaluacion_cantidad = table.Column<double>(nullable: true),
                    floiodcporcentaje_evaluacion_tiempo = table.Column<double>(nullable: true),
                    floiodcporcentaje_evaluacion_calidad = table.Column<double>(nullable: true),
                    floiodcporcentaje_evaluacion_cantidad = table.Column<double>(nullable: true),
                    datiodcfecha_evaluacion = table.Column<DateTime>(type: "date", nullable: true),
                    intiodcanulado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intiodcrecibido = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intiodcabierto = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intiodcpagado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floiodccantidad = table.Column<double>(nullable: true),
                    floiodccantidad1 = table.Column<double>(nullable: true),
                    floiodccantidadr = table.Column<double>(nullable: true),
                    floiodccantidadver = table.Column<double>(nullable: true),
                    floiodccosto = table.Column<double>(nullable: true),
                    intiodcestado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    variodcrazon_social_proveedor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    variodcobservaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    variodctipo_orden = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    variodccondiciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    floiodcevaltiempo = table.Column<double>(nullable: true),
                    floiodcevalcantidad = table.Column<double>(nullable: true),
                    floiodcevalcalidad = table.Column<double>(nullable: true),
                    datiodcfechaeval = table.Column<DateTime>(type: "date", nullable: true),
                    floiodcportiempo = table.Column<double>(nullable: true),
                    floiodcporcantidad = table.Column<double>(nullable: true),
                    floiodcporcalidad = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblitems__30800C1C51295312", x => x.intiodcconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblitems_recepcion_proveedors",
                columns: table => new
                {
                    intirpsconsecutivo = table.Column<int>(nullable: false),
                    intirpsnumero_rps = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varirpsreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floirpscantidad_recibida = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblitems__F6298044930504BA", x => x.intirpsconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblitems_remision1",
                columns: table => new
                {
                    intirem1consecutivo = table.Column<int>(nullable: false),
                    intirem1numero_remision = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varirem1referencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floirem1cantidad_remisionada = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblitems__01F2090F99BABDD4", x => x.intirem1consecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblitems_temporal_godcs",
                columns: table => new
                {
                    intitgoconsecutivo = table.Column<int>(nullable: false),
                    intitgonumero_odcs = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varitgoreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floitgocantidad = table.Column<double>(nullable: true),
                    floitgovalor_pactado = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblitems__40700524EBF08032", x => x.intitgoconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblitems_temporal_gremision",
                columns: table => new
                {
                    intitgrconsecutivo = table.Column<int>(nullable: false),
                    intitgrnumero_remision = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varitgrreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floitgrcantidad = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblitems__0456D4FF2B404445", x => x.intitgrconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblitems_temporal_ods",
                columns: table => new
                {
                    intitoconsecutivo = table.Column<int>(nullable: false),
                    intitonumero_to = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varitoreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floitocantidad = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblitems__67B9006820696787", x => x.intitoconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tbllineas",
                columns: table => new
                {
                    intcodigo = table.Column<int>(nullable: false),
                    intlineas = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    vardescripcion = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbllinea__CC0F1ED85560B5BA", x => x.intcodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblmaquina",
                columns: table => new
                {
                    intmaqconsecutivo = table.Column<int>(nullable: false),
                    varmaqcodigo = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    varmaqdescripcion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varmaqmarca = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmaqui__10E99FCF91E905E3", x => x.intmaqconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblmateria_prima",
                columns: table => new
                {
                    intmpconsecutivo = table.Column<int>(nullable: false),
                    varmpreferencia = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    varmpdescripcion = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    intmplinea = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmpunidad_medida = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    flompotro = table.Column<double>(nullable: true),
                    flompespesor = table.Column<double>(nullable: true),
                    flomplargo = table.Column<double>(nullable: true),
                    flompancho = table.Column<double>(nullable: true),
                    flompcosto_unidad = table.Column<double>(nullable: true),
                    varmpevaluador = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    varmptipo = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    flompcantidad = table.Column<double>(nullable: true),
                    varmpdensidadKgUn = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmppatron = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmpfecha_aproba_patron = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmpdocumento_o_plano = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmpfecha_aproba_plano = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmpguia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmpuso_guia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmpfecha_aproba_guia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flompprecio_ventav = table.Column<double>(nullable: true),
                    flompprecio_ventan = table.Column<double>(nullable: true),
                    flompdescuento = table.Column<double>(nullable: true),
                    intmpauto_liberable = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    flomppunto_minimo = table.Column<double>(nullable: true),
                    flomppunto_maximo = table.Column<double>(nullable: true),
                    intmpestado = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmater__3880AB02A91BA3C7", x => new { x.intmpconsecutivo, x.varmpreferencia });
                });

            migrationBuilder.CreateTable(
                name: "tblmateriales_ajuste",
                columns: table => new
                {
                    intmajconsecutivo = table.Column<int>(nullable: false),
                    intmajnumero = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmajtipo = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    varmajen = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intmajen1 = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmajtipo1 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    varmajproducto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flomajcantidad = table.Column<double>(nullable: true),
                    varmajunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    intmajacept = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmajen2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varmajobservaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmater__6D97CBA56460E149", x => x.intmajconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblmateriales_planta",
                columns: table => new
                {
                    intmapconsecutivo = table.Column<int>(nullable: false),
                    intmapnumero = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmapproducto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmapoperario = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flomapcantidad = table.Column<double>(nullable: true),
                    varmapobservaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmater__9930D0B5F73D8EF9", x => x.intmapconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblmateriales_remision",
                columns: table => new
                {
                    intmrconsecutivo = table.Column<int>(nullable: false),
                    intmrnumero_remision = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmrpara = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmrpor = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmrreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flomrcantidad = table.Column<double>(nullable: true),
                    flomrcosto = table.Column<double>(nullable: true),
                    intmrnumpat = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmater__965385517C19BCEC", x => x.intmrconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblmateriales_remision1",
                columns: table => new
                {
                    intmr1consecutivo = table.Column<int>(nullable: false),
                    intmr1numero = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmr1producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmr1proveedor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    flomr1cantidad = table.Column<double>(nullable: true),
                    varmr1observaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmater__00DD33F5FCCFD913", x => x.intmr1consecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblmotivo_devolucion",
                columns: table => new
                {
                    intmdconsecutivo = table.Column<int>(nullable: false),
                    intmdcodigo = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varmddescripcion = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmotiv__C14C00AA2DC197A8", x => x.intmdconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblmovimiento",
                columns: table => new
                {
                    intmovconsecutivo = table.Column<int>(nullable: false),
                    varmovtipo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varmovrealizado_por = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    intmovnumero_patenta = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    flomovcantidad = table.Column<double>(nullable: true),
                    varmovunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    varmovreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varmovtipo_referencia = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varmovde = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    varmovpara = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    varmovafecta = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    varmovrecibio = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    datmovfecha = table.Column<DateTime>(type: "date", nullable: true),
                    flomovcantidad1 = table.Column<double>(nullable: true),
                    flomovcantidad2 = table.Column<double>(nullable: true),
                    varmovresponsable_movimiento = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblmovim__8FA65D7BA880DB00", x => x.intmovconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblnovedades",
                columns: table => new
                {
                    intnovconsecutivo = table.Column<int>(nullable: false),
                    varnovdebida_a = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varnovnovedad = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varnovafecta = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varnovrealizada_por = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    datnovfecha = table.Column<DateTime>(type: "date", nullable: true),
                    timnovhora = table.Column<TimeSpan>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblnoved__EB0206A0F0DD8EC3", x => x.intnovconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tbloperario",
                columns: table => new
                {
                    intopecodigo = table.Column<int>(nullable: false),
                    varopeinicial = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    varopenombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varopeapellido = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    floopesalario_hora = table.Column<double>(nullable: true),
                    intopeestado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    datopefecha_ingreso = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblopera__60534266EA2200AD", x => new { x.intopecodigo, x.varopeinicial });
                });

            migrationBuilder.CreateTable(
                name: "tblorden_compra",
                columns: table => new
                {
                    intocnumero = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    datocfecha = table.Column<DateTime>(type: "date", nullable: true),
                    intoctipo = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intocproveedor = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intocliberada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intocanulada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intocrecibida = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intocabierta = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intocpagada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varoccondiciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varocobservaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    intocevaluacion_atencion = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floocevaluacion_tiempo = table.Column<double>(nullable: true),
                    floocevaluacion_calidad = table.Column<double>(nullable: true),
                    floocevaluacion_cantidad = table.Column<double>(nullable: true),
                    floocporcentaje_evaluacion_tiempo = table.Column<double>(nullable: true),
                    floocporcentaje_evaluacion_calidad = table.Column<double>(nullable: true),
                    floocporcentaje_evaluacion_cantidad = table.Column<double>(nullable: true),
                    datocfecha_evaluacion = table.Column<DateTime>(type: "date", nullable: true),
                    intocasociada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intocterminada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varocrazon_social_proveedor = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varoctipo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intocatencion_compra = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floocevaltiempo = table.Column<double>(nullable: true),
                    floocevalcantidad = table.Column<double>(nullable: true),
                    floocevalcalidad = table.Column<double>(nullable: true),
                    datocfechaeval = table.Column<DateTime>(type: "date", nullable: true),
                    floocportiempo = table.Column<double>(nullable: true),
                    floocporcantidad = table.Column<double>(nullable: true),
                    floocporcalidad = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblorden__00A200C3BF3C0B78", x => x.intocnumero);
                });

            migrationBuilder.CreateTable(
                name: "tblorden_produccion",
                columns: table => new
                {
                    intopnumero = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    datopfecha_generacion = table.Column<DateTime>(type: "date", nullable: true),
                    varopreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    intopcantidad_ordenada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varopnotas = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varopobservaciones = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    floopcantidad_inspeccionar = table.Column<double>(nullable: true),
                    intopliberada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intopanulada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intoprealizada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intopabierta = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varopresponsable_generacion = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varopfechas_liberacion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varopresponsables_liberacion = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varopfechas_actualizacion = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varopresponsables_actualizacion = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    datopfecha_anulacion = table.Column<DateTime>(type: "date", nullable: true),
                    varopresponsable_anulacion = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    intopcantidad_adelantada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intopcantidad_conforme = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intopcantidad_no_conforme = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floopduracion = table.Column<double>(nullable: true),
                    floopcosto_unidad = table.Column<double>(nullable: true),
                    intopcantidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    datopfecha = table.Column<DateTime>(type: "date", nullable: true),
                    varopobservaciones1 = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    intopcantidad1 = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intopterminada = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    datopfecha_termino = table.Column<DateTime>(type: "date", nullable: true),
                    intopcantidadr = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblorden__89585C412AB751A1", x => x.intopnumero);
                });

            migrationBuilder.CreateTable(
                name: "tblpadre",
                columns: table => new
                {
                    varpadreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    varpadreferencia_padre = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    flopadcantidad = table.Column<double>(nullable: true),
                    varpadtipo = table.Column<string>(unicode: false, maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    flopadcosto = table.Column<double>(nullable: true),
                    varpadunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    varpadtipo1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    flopadcosto1 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblpadre__566DA64266B09C46", x => new { x.varpadreferencia_producto, x.varpadreferencia_padre });
                });

            migrationBuilder.CreateTable(
                name: "tblpais",
                columns: table => new
                {
                    intpaicodigo = table.Column<int>(nullable: false),
                    varpainombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblpais__89598B35A4704636", x => x.intpaicodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblplanta",
                columns: table => new
                {
                    intplconsecutivo = table.Column<int>(nullable: false),
                    floplcantidad = table.Column<double>(nullable: true),
                    varplreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varpltipo_referencia = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    floplcantidad1 = table.Column<double>(nullable: true),
                    varplunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblplant__3DFA2B00ECE3C177", x => x.intplconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblproceso_maquina",
                columns: table => new
                {
                    intpmcodigo_proceso = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    intpmconse_maquina = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblproce__D381AA64785777DF", x => new { x.intpmcodigo_proceso, x.intpmconse_maquina });
                });

            migrationBuilder.CreateTable(
                name: "tblproceso_operario",
                columns: table => new
                {
                    intpocodigo_proceso = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    intpocodigo_operario = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    intponumero_orden = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    intpotipo = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblproce__3C0117413BA603C1", x => new { x.intpocodigo_proceso, x.intpocodigo_operario, x.intponumero_orden, x.intpotipo });
                });

            migrationBuilder.CreateTable(
                name: "tblproceso_producto",
                columns: table => new
                {
                    intppptcodigo_proceso = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    varppptreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    intppptorden = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblproce__E932001C02569BAC", x => new { x.intppptcodigo_proceso, x.varppptreferencia_producto });
                });

            migrationBuilder.CreateTable(
                name: "tblprocesoe",
                columns: table => new
                {
                    intproecodigo = table.Column<int>(nullable: false),
                    varproedescripcion = table.Column<string>(unicode: false, maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    intproecodigo_tipo = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblproce__2F48ADF44D659BC1", x => new { x.intproecodigo, x.varproedescripcion });
                });

            migrationBuilder.CreateTable(
                name: "tblproducto_proceso",
                columns: table => new
                {
                    intppconsecutivo = table.Column<int>(nullable: false),
                    varppreferencia = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    varppdescripcion = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    intpplinea = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varppunidad_medida = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    flopplargo = table.Column<double>(nullable: true),
                    floppancho = table.Column<double>(nullable: true),
                    floppcosto = table.Column<double>(nullable: true),
                    varpptipo = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    floppservicio = table.Column<double>(nullable: true),
                    datppfecha_actproces = table.Column<DateTime>(type: "date", nullable: true),
                    datppfecha_actcompo = table.Column<DateTime>(type: "date", nullable: true),
                    floppcantidad = table.Column<double>(nullable: true),
                    varppdensidadKgUn = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varpppatron = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varppfecha_aproba_patron = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varppdocumento_o_plano = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varppfecha_aproba_plano = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varppguia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varppuso_guia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varppfecha_aproba_guia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floppprecio_ventav = table.Column<double>(nullable: true),
                    floppprecio_ventan = table.Column<double>(nullable: true),
                    floppdescuento = table.Column<double>(nullable: true),
                    intppauto_liberable = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    flopppunto_minimo = table.Column<double>(nullable: true),
                    flopppunto_maximo = table.Column<double>(nullable: true),
                    intppestado = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblprodu__C65C92F1248059CD", x => new { x.intppconsecutivo, x.varppreferencia });
                });

            migrationBuilder.CreateTable(
                name: "tblproducto_terminado",
                columns: table => new
                {
                    intptconsecutivo = table.Column<int>(nullable: false),
                    varptreferencia = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    varptdescripcion = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    intptlinea = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varptunidad_medida = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    floptcosto = table.Column<double>(nullable: true),
                    datptfecha_actproces = table.Column<DateTime>(type: "date", nullable: true),
                    datptfecha_actcompo = table.Column<DateTime>(type: "date", nullable: true),
                    floptcantidad = table.Column<double>(nullable: true),
                    varptdensidadKgUn = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varptpatron = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varptfecha_aproba_patron = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varptdocumento_o_plano = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varptfecha_aproba_plano = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varptguia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varptuso_guia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varptfecha_aproba_guia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    floptprecio_ventav = table.Column<double>(nullable: true),
                    floptprecio_ventan = table.Column<double>(nullable: true),
                    floptdescuento = table.Column<double>(nullable: true),
                    intptauto_liberable = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    floptpunto_minimo = table.Column<double>(nullable: true),
                    floptpunto_maximo = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblprodu__A2841874062F1A23", x => new { x.intptconsecutivo, x.varptreferencia });
                });

            migrationBuilder.CreateTable(
                name: "tblproductos_cliente",
                columns: table => new
                {
                    intpctconsecutivo = table.Column<int>(nullable: false),
                    varpctpor = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    intpctnumero = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varpctcliente = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    flopctcantidad = table.Column<double>(nullable: true),
                    varpctproducto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varpctobservaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblprodu__CEF50F33E3389817", x => x.intpctconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblproveedor",
                columns: table => new
                {
                    intpvconsecutivo = table.Column<int>(nullable: false),
                    flopvcantidad = table.Column<double>(nullable: true),
                    varpvreferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varpvrazon_social = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varpvtipo_referencia = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    flopvcantidad1 = table.Column<double>(nullable: true),
                    varpvpermilib = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    varpvunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblprove__3DAAA6F85874B1A4", x => x.intpvconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblproveedormp",
                columns: table => new
                {
                    intpmpcodigo = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    varpmprazon_social = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varpmpnit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpmpdireccion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intpmpciudad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varpmptelefono = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpmpfax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpmpemail = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpmpcontacto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intpmpestado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intpmpcontrolado_calidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intpmptipo_calidad = table.Column<int>(nullable: true, defaultValueSql: "('3')"),
                    flopmpevaluacion = table.Column<double>(nullable: true),
                    datpmpfecha_evaluacion = table.Column<DateTime>(type: "date", nullable: true),
                    flopmpdescuento = table.Column<double>(nullable: true),
                    intpmptiempo_entrega = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intpmpplazo = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varpmpproducto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpmpevaluaciones_calidad = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varpmpactualizaciones = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varpmpquien_realiza = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    datpmpfecha_ingreso = table.Column<DateTime>(type: "date", nullable: true),
                    varpmpde = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpmpciudad = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblprove__01A76AEAD0FD07FD", x => x.intpmpcodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblproveedors",
                columns: table => new
                {
                    intpscodigo = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    varpsrazon_social = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varpsnit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpsdireccion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intpsciudad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varpstelefono = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpsfax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpsemail = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpscontacto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    intpsestado = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intpscontrolado_calidad = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intpstipo_calidad = table.Column<int>(nullable: true, defaultValueSql: "('3')"),
                    flopsevaluacion = table.Column<double>(nullable: true),
                    datpsfecha_evaluacion = table.Column<DateTime>(type: "date", nullable: true),
                    flopsdescuento = table.Column<double>(nullable: true),
                    intpstiempo_entrega = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intpsplazo = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varpsproducto = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpsevaluaciones_calidad = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varpsactualizaciones = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    varpsquien_realiza = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    datpsfecha_ingreso = table.Column<DateTime>(type: "date", nullable: true),
                    varpsde = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varpsciudad = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblprove__AAEE78FEA0CEC351", x => x.intpscodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblrecepcion_planta",
                columns: table => new
                {
                    intrpconsecutivo = table.Column<int>(nullable: false),
                    varrpforma = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varrpoperario_entrega = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varrpobservaciones = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    intrpnumero = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intrpcantidad_posible_recibir = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varrpreferencia = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    intrpcantidad_recibida = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblrecep__27C25FD64CBBC44B", x => x.intrpconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblrecepcion_proveedors",
                columns: table => new
                {
                    intrpsnumero = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    datrpsfecha = table.Column<DateTime>(type: "date", nullable: true),
                    intrpsproveedor = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varrpsobservaciones = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblrecep__26C76A437338916C", x => x.intrpsnumero);
                });

            migrationBuilder.CreateTable(
                name: "tblrecmatpvs",
                columns: table => new
                {
                    intspconsecutivo = table.Column<int>(nullable: false),
                    varspproveedor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varspproducto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flospcantidad = table.Column<double>(nullable: true),
                    flospcantidad1 = table.Column<double>(nullable: true),
                    varspobservaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblrecma__9B04CB4F73C2642D", x => x.intspconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tblremision",
                columns: table => new
                {
                    intremnumero = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    datremfecha = table.Column<DateTime>(type: "date", nullable: true),
                    varrempara = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varrempor = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    varremobservaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    intremnumpat = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblremis__4BA122292DC0A615", x => x.intremnumero);
                });

            migrationBuilder.CreateTable(
                name: "tblremision1",
                columns: table => new
                {
                    intrem1numero = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    datrem1fecha = table.Column<DateTime>(type: "date", nullable: true),
                    intrem1proveedor = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    varrem1observaciones = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    varrem1proveedor = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblremis__38B7DBDE0C71CD02", x => x.intrem1numero);
                });

            migrationBuilder.CreateTable(
                name: "tblseg_opcion_menu",
                columns: table => new
                {
                    idopcion = table.Column<byte>(nullable: false),
                    strnombre = table.Column<string>(unicode: false, maxLength: 80, nullable: false, defaultValueSql: "('')"),
                    dtmfecha = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "('2000-00-00')"),
                    strdescripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    strlink = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    intnivel = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    intidopcion = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblseg_o__8C01E19B3EBF5E8A", x => x.idopcion);
                });

            migrationBuilder.CreateTable(
                name: "tblseg_opcion_menuant",
                columns: table => new
                {
                    idopcion = table.Column<byte>(nullable: false),
                    strnombre = table.Column<string>(unicode: false, maxLength: 80, nullable: false, defaultValueSql: "('')"),
                    dtmfecha = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "('2000-00-00')"),
                    strdescripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    strlink = table.Column<string>(unicode: false, maxLength: 100, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblseg_o__8C01E19B625FEFEE", x => x.idopcion);
                });

            migrationBuilder.CreateTable(
                name: "tblseg_opcion_perfil",
                columns: table => new
                {
                    idperfil = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    idopcion = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblseg_o__AA35195F753E6068", x => new { x.idperfil, x.idopcion });
                });

            migrationBuilder.CreateTable(
                name: "tblseg_opcion_perfilant",
                columns: table => new
                {
                    idperfil = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    idopcion = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblseg_o__AA35195FFAE5105B", x => new { x.idperfil, x.idopcion });
                });

            migrationBuilder.CreateTable(
                name: "tblseg_perfiles",
                columns: table => new
                {
                    idperfil = table.Column<byte>(nullable: false),
                    strnombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    strdescripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblseg_p__02F50746C58EB1CB", x => x.idperfil);
                });

            migrationBuilder.CreateTable(
                name: "tblseg_perfilesant",
                columns: table => new
                {
                    idperfil = table.Column<byte>(nullable: false),
                    strnombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    strdescripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblseg_p__02F507465829E1C6", x => x.idperfil);
                });

            migrationBuilder.CreateTable(
                name: "tbltelefono_cliente",
                columns: table => new
                {
                    inttccodigo = table.Column<int>(nullable: false),
                    inttccliente = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    inttctipo_telefono = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vartctelefono = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltelef__90F82FF85559FD36", x => x.inttccodigo);
                });

            migrationBuilder.CreateTable(
                name: "tbltemp",
                columns: table => new
                {
                    inttmpconsecutivo = table.Column<int>(nullable: false),
                    vartmpproveedor = table.Column<int>(nullable: true, defaultValueSql: "('0')"),
                    vartmpproducto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flotmpcantidad = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltemp__8909CF557FC2EDE4", x => x.inttmpconsecutivo);
                });

            migrationBuilder.CreateTable(
                name: "tbltemp1",
                columns: table => new
                {
                    inttmpcodigo = table.Column<int>(nullable: false),
                    inttmpcodproc = table.Column<int>(nullable: true),
                    vartmpcodmaq = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltemp1__4CD539373868172E", x => x.inttmpcodigo);
                });

            migrationBuilder.CreateTable(
                name: "tbltemp2",
                columns: table => new
                {
                    inttmpnumero_orden = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    inttmpcodigo_proceso = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    vartmpcodigo_operario = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flotmpcostomo = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltemp2__8276EB0BFE7B9199", x => new { x.inttmpnumero_orden, x.inttmpcodigo_proceso });
                });

            migrationBuilder.CreateTable(
                name: "tbltemporal_godcs",
                columns: table => new
                {
                    inttgonumero = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltempo__C63474E83B720BF7", x => x.inttgonumero);
                });

            migrationBuilder.CreateTable(
                name: "tbltemporal_gremision",
                columns: table => new
                {
                    inttgrnumero = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltempo__86D814BDE3929F13", x => x.inttgrnumero);
                });

            migrationBuilder.CreateTable(
                name: "tbltemporal_ods",
                columns: table => new
                {
                    inttonumero = table.Column<int>(nullable: false, defaultValueSql: "('0')"),
                    inttoproveedor = table.Column<int>(nullable: true, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltempo__9AA8376E82AEC5BF", x => x.inttonumero);
                });

            migrationBuilder.CreateTable(
                name: "tbltipo_proceso",
                columns: table => new
                {
                    inttpcodigo = table.Column<int>(nullable: false),
                    vartpdescripcion = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbltipo___75269072DE5F8A10", x => x.inttpcodigo);
                });

            migrationBuilder.CreateTable(
                name: "tblusuarios",
                columns: table => new
                {
                    idusuario = table.Column<byte>(nullable: false),
                    idperfil = table.Column<byte>(nullable: false, defaultValueSql: "('0')"),
                    strlogin = table.Column<string>(unicode: false, maxLength: 30, nullable: false, defaultValueSql: "('')"),
                    strdescripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    password = table.Column<string>(unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    estado = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblusuar__080A97433A101E85", x => x.idusuario);
                });

            migrationBuilder.CreateTable(
                name: "tblusuariosant",
                columns: table => new
                {
                    idusuario = table.Column<byte>(nullable: false),
                    idperfil = table.Column<byte>(nullable: false, defaultValueSql: "('0')"),
                    strlogin = table.Column<string>(unicode: false, maxLength: 80, nullable: false, defaultValueSql: "('')"),
                    strdescripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    password = table.Column<string>(unicode: false, maxLength: 10, nullable: false, defaultValueSql: "('')"),
                    estado = table.Column<int>(nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblusuar__080A9743CFFEE2F4", x => x.idusuario);
                });

            migrationBuilder.CreateTable(
                name: "tblzona_amarilla",
                columns: table => new
                {
                    intzaconsecutivo = table.Column<int>(nullable: false),
                    varzatipo_referencia = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    varzareferencia_producto = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    flozacantidad = table.Column<double>(nullable: true),
                    varzaunidad = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblzona___14F47F5F2A6A64BB", x => x.intzaconsecutivo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblalertas");

            migrationBuilder.DropTable(
                name: "tblciudad");

            migrationBuilder.DropTable(
                name: "tblcliente");

            migrationBuilder.DropTable(
                name: "tblclientet");

            migrationBuilder.DropTable(
                name: "tblconsecutivo_documentos");

            migrationBuilder.DropTable(
                name: "tblcontacto_cliente");

            migrationBuilder.DropTable(
                name: "tbldatos_evaluacion");

            migrationBuilder.DropTable(
                name: "tbldatos_procesodp");

            migrationBuilder.DropTable(
                name: "tbldepartamento");

            migrationBuilder.DropTable(
                name: "tbldescuento_cliente");

            migrationBuilder.DropTable(
                name: "tbldesperdicio");

            migrationBuilder.DropTable(
                name: "tbldetalle_consecutivo_documentos");

            migrationBuilder.DropTable(
                name: "tbldetalle_documento_recepcion");

            migrationBuilder.DropTable(
                name: "tbldetalle_orden_produccion");

            migrationBuilder.DropTable(
                name: "tbldevolucion_noconforme");

            migrationBuilder.DropTable(
                name: "tbldireccion_cliente");

            migrationBuilder.DropTable(
                name: "tbldocumento_recepcion");

            migrationBuilder.DropTable(
                name: "tblemail_cliente");

            migrationBuilder.DropTable(
                name: "tblevaluacion_odcs");

            migrationBuilder.DropTable(
                name: "tblitems_odc");

            migrationBuilder.DropTable(
                name: "tblitems_recepcion_proveedors");

            migrationBuilder.DropTable(
                name: "tblitems_remision1");

            migrationBuilder.DropTable(
                name: "tblitems_temporal_godcs");

            migrationBuilder.DropTable(
                name: "tblitems_temporal_gremision");

            migrationBuilder.DropTable(
                name: "tblitems_temporal_ods");

            migrationBuilder.DropTable(
                name: "tbllineas");

            migrationBuilder.DropTable(
                name: "tblmaquina");

            migrationBuilder.DropTable(
                name: "tblmateria_prima");

            migrationBuilder.DropTable(
                name: "tblmateriales_ajuste");

            migrationBuilder.DropTable(
                name: "tblmateriales_planta");

            migrationBuilder.DropTable(
                name: "tblmateriales_remision");

            migrationBuilder.DropTable(
                name: "tblmateriales_remision1");

            migrationBuilder.DropTable(
                name: "tblmotivo_devolucion");

            migrationBuilder.DropTable(
                name: "tblmovimiento");

            migrationBuilder.DropTable(
                name: "tblnovedades");

            migrationBuilder.DropTable(
                name: "tbloperario");

            migrationBuilder.DropTable(
                name: "tblorden_compra");

            migrationBuilder.DropTable(
                name: "tblorden_produccion");

            migrationBuilder.DropTable(
                name: "tblpadre");

            migrationBuilder.DropTable(
                name: "tblpais");

            migrationBuilder.DropTable(
                name: "tblplanta");

            migrationBuilder.DropTable(
                name: "tblproceso_maquina");

            migrationBuilder.DropTable(
                name: "tblproceso_operario");

            migrationBuilder.DropTable(
                name: "tblproceso_producto");

            migrationBuilder.DropTable(
                name: "tblprocesoe");

            migrationBuilder.DropTable(
                name: "tblproducto_proceso");

            migrationBuilder.DropTable(
                name: "tblproducto_terminado");

            migrationBuilder.DropTable(
                name: "tblproductos_cliente");

            migrationBuilder.DropTable(
                name: "tblproveedor");

            migrationBuilder.DropTable(
                name: "tblproveedormp");

            migrationBuilder.DropTable(
                name: "tblproveedors");

            migrationBuilder.DropTable(
                name: "tblrecepcion_planta");

            migrationBuilder.DropTable(
                name: "tblrecepcion_proveedors");

            migrationBuilder.DropTable(
                name: "tblrecmatpvs");

            migrationBuilder.DropTable(
                name: "tblremision");

            migrationBuilder.DropTable(
                name: "tblremision1");

            migrationBuilder.DropTable(
                name: "tblseg_opcion_menu");

            migrationBuilder.DropTable(
                name: "tblseg_opcion_menuant");

            migrationBuilder.DropTable(
                name: "tblseg_opcion_perfil");

            migrationBuilder.DropTable(
                name: "tblseg_opcion_perfilant");

            migrationBuilder.DropTable(
                name: "tblseg_perfiles");

            migrationBuilder.DropTable(
                name: "tblseg_perfilesant");

            migrationBuilder.DropTable(
                name: "tbltelefono_cliente");

            migrationBuilder.DropTable(
                name: "tbltemp");

            migrationBuilder.DropTable(
                name: "tbltemp1");

            migrationBuilder.DropTable(
                name: "tbltemp2");

            migrationBuilder.DropTable(
                name: "tbltemporal_godcs");

            migrationBuilder.DropTable(
                name: "tbltemporal_gremision");

            migrationBuilder.DropTable(
                name: "tbltemporal_ods");

            migrationBuilder.DropTable(
                name: "tbltipo_proceso");

            migrationBuilder.DropTable(
                name: "tblusuarios");

            migrationBuilder.DropTable(
                name: "tblusuariosant");

            migrationBuilder.DropTable(
                name: "tblzona_amarilla");
        }
    }
}
