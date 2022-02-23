using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDBBlog.Models
{
    public class Productos
    {
        public static List<ProductosItems> ListProductos()
        {
            List<ProductosItems> lista = new List<ProductosItems>();
            

            lista.Add(new ProductosItems() { Nombre = "CARBON ACTIVADO",
            alt = "CARBON ACTIVADO",
            Ruta = "Imagenes/Producto/3 CARBON ACTIVADO.jpg",
            categoria = 1,
            orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "HIPOCLORITO DE CALCIO",
                alt = "HIPOCLORITO DE CALCIO",
                Ruta = "Imagenes/Producto/3 HIPOCLORITO DE CALCIO.jpg",
                categoria = 1,
                orden = 2
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "RESINAS ANIONICAS Y CATIONICAS",
                alt = "RESINAS ANIONICAS Y CATIONICAS",
                Ruta = "Imagenes/Producto/3 RESINAS ANIONICAS Y CATIONICAS.jpg",
                categoria = 1,
                orden = 9
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SULFATO DE ALUMINA TIPO A",
                alt = "SULFATO DE ALUMINA TIPO A",
                Ruta = "Imagenes/Producto/3 Sulfato DE ALUMINA TIPO A.png",
                categoria = 1,
                orden = 4
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "ZEOLITA TURBIDEX",
                alt = "ZEOLITA TURBIDEX",
                Ruta = "Imagenes/Producto/3 ZEOLITA TURBIDEX.jpg",
                categoria = 1,
                orden = 5
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "ANTRACITA",
                alt = "ANTRACITA",
                Ruta = "Imagenes/Producto/4 ANTRACITA.jpg",
                categoria = 1,
                orden = 6
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "ARENA DE CUARZO",
                alt = "ARENA DE CUARZO",
                Ruta = "Imagenes/Producto/4 ARENA DE CUARZO.jpg",
                categoria = 1,
                orden = 7
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "GRAVA DE CUARZO",
                alt = "GRAVA DE CUARZO",
                Ruta = "Imagenes/Producto/4 GRAVA DE CUARZO.png",
                categoria = 1,
                orden = 8
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "ABLANDADORES DE AGUA",
                alt = "ABLANDADORES DE AGUA",
                Ruta = "Imagenes/Producto/ABLANDADORES DE AGUA.jpg",
                categoria = 1,
                orden = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "BASE Y SOPORTE PARA FILTROS",
                alt = "BASE Y SOPORTE PARA FILTROS",
                Ruta = "Imagenes/Producto/BASE Y SOPORTE PARA FILTROS.jpg",
                categoria = 1,
                orden = 10
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "BOMBA DE AGUA MULTIETAPA VERTICAL CNP",
                alt = "BOMBA DE AGUA MULTIETAPA VERTICAL CNP",
                Ruta = "Imagenes/Producto/BOMBA DE AGUA MULTIETAPA VERTICAL CNP.png",
                categoria = 1,
                orden = 11
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "BOMBA DE REFUERZO PARA OSMOSIS – GOULDS",
                alt = "BOMBA DE REFUERZO PARA OSMOSIS – GOULDS",
                Ruta = "Imagenes/Producto/BOMBA DE REFUERZO PARA OSMOSIS – GOULDS.jpg",
                categoria = 1,
                orden = 12
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "BOMBA PARA OSMOSIS 100 200 GPD",
                alt = "BOMBA PARA OSMOSIS 100 200 GPD",
                Ruta = "Imagenes/Producto/BOMBA PARA OSMOSIS 100 200 GPD.jpg",
                categoria = 1,
                orden = 13
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "CONECTORES RÁPIDOS",
                alt = "CONECTORES RÁPIDOS",
                Ruta = "Imagenes/Producto/CONECTORES RÁPIDOS.jpg",
                categoria = 1,
                orden = 20
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "EQUIPO ULTRAVIOLETA HIDROTEK",
                alt = "EQUIPO ULTRAVIOLETA HIDROTEK",
                Ruta = "Imagenes/Producto/EQUIPO ULTRAVIOLETA HIDROTEK.jpg",
                categoria = 1,
                orden = 15
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "EQUIPO UV POLARIS",
                alt = "EQUIPO UV POLARIS",
                Ruta = "Imagenes/Producto/EQUIPO UV POLARIS.jpg",
                categoria = 1,
                orden = 27
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "EQUIPOS ULTRAVIOLETA VIQUA",
                alt = "EQUIPOS ULTRAVIOLETA VIQUA",
                Ruta = "Imagenes/Producto/EQUIPOS ULTRAVIOLETA VIQUA.jpg",
                categoria = 1,
                orden = 17
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FILTRO DE CARBON ACTIVADO",
                alt = "FILTRO DE CARBON ACTIVADO",
                Ruta = "Imagenes/Producto/FILTRO DE CARBON ACTIVADO.jpg",
                categoria = 1,
                orden = 18
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FILTRO DE MULTIMEDIA",
                alt = "FILTRO DE MULTIMEDIA",
                Ruta = "Imagenes/Producto/FILTRO DE MULTIMEDIA.jpg",
                categoria = 1,
                orden = 19
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FILTROS CARTUCHOS DE CARBON ACTIVADO",
                alt = "FILTROS CARTUCHOS DE CARBON ACTIVADO",
                Ruta = "Imagenes/Producto/FILTROS CARTUCHOS DE CARBON ACTIVADO.jpg",
                categoria = 1,
                orden = 14
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FILTROS CARTUCHOS DE SEDIMENTO",
                alt = "FILTROS CARTUCHOS DE SEDIMENTO",
                Ruta = "Imagenes/Producto/FILTROS CARTUCHOS DE SEDIMENTO.jpg",
                categoria = 1,
                orden = 21
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FILTROS CARTUCHOS PLISADOS",
                alt = "FILTROS CARTUCHOS PLISADOS",
                Ruta = "Imagenes/Producto/FILTROS CARTUCHOS PLISADOS.png",
                categoria = 1,
                orden = 21
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FLUJOMETRO DE AGUA EN LINEA Y PAPEL",
                alt = "FLUJOMETRO DE AGUA EN LINEA Y PAPEL",
                Ruta = "Imagenes/Producto/FLUJOMETRO DE AGUA EN LINEA Y PAPEL.jpg",
                categoria = 1,
                orden = 22
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "GENERADOR DE OZONO",
                alt = "GENERADOR DE OZONO",
                Ruta = "Imagenes/Producto/GENERADOR DE OZONO.jpg",
                categoria = 1,
                orden = 26
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "MANGUERAS DE POLIETILENO",
                alt = "MANGUERAS DE POLIETILENO",
                Ruta = "Imagenes/Producto/MANGUERAS DE POLIETILENO.jpg",
                categoria = 1,
                orden = 24
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "MANÓMETROS PARA AGUA DE GLICERINA",
                alt = "MANÓMETROS PARA AGUA DE GLICERINA",
                Ruta = "Imagenes/Producto/MANÓMETROS PARA AGUA DE GLICERINA.jpg",
                categoria = 1,
                orden = 23
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "MEDIDOR DE CONDUCTIVIDAD CON MONITOR",
                alt = "MEDIDOR DE CONDUCTIVIDAD CON MONITOR",
                Ruta = "Imagenes/Producto/MEDIDOR DE CONDUCTIVIDAD CON MONITOR.jpg",
                categoria = 1,
                orden = 16
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "MEMBRANA DE ÓSMOSIS HIDROTEK",
                alt = "MEMBRANA DE ÓSMOSIS HIDROTEK",
                Ruta = "Imagenes/Producto/MEMBRANA DE ÓSMOSIS HIDROTEK.jpg",
                categoria = 1,
                orden = 32
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "MEMBRANA DE ÓSMOSIS HYDRON",
                alt = "MEMBRANA DE ÓSMOSIS HYDRON",
                Ruta = "Imagenes/Producto/MEMBRANA DE ÓSMOSIS HYDRON.jpg",
                categoria = 1,
                orden = 29
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "MEMBRANA DE ÓSMOSIS TORAY",
                alt = "MEMBRANA DE ÓSMOSIS TORAY",
                Ruta = "Imagenes/Producto/MEMBRANA DE ÓSMOSIS TORAY.jpg",
                categoria = 1,
                orden = 30
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "OZONIZADOR DE AGUA",
                alt = "OZONIZADOR DE AGUA",
                Ruta = "Imagenes/Producto/OZONIZADOR DE AGUA.jpg",
                categoria = 1,
                orden = 33
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PORTACARTUCHOS",
                alt = "PORTACARTUCHOS",
                Ruta = "Imagenes/Producto/PORTACARTUCHOS.jpg",
                categoria = 1,
                orden = 28
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PORTAMEMBRANAS ACERO INOXIDABLE",
                alt = "PORTAMEMBRANAS ACERO INOXIDABLE",
                Ruta = "Imagenes/Producto/PORTAMEMBRANAS ACERO INOXIDABLE.jpg",
                categoria = 1,
                orden = 31
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PORTAMEMBRANAS FRP",
                alt = "PORTAMEMBRANAS FRP",
                Ruta = "Imagenes/Producto/PORTAMEMBRANAS FRP.jpg",
                categoria = 1,
                orden = 34
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "TANQUES DE FIBRA DE VIDRIO",
                alt = "TANQUES DE FIBRA DE VIDRIO",
                Ruta = "Imagenes/Producto/TANQUES DE FIBRA DE VIDRIO.jpg",
                categoria = 1,
                orden = 35
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "TOBERAS O DISTRIBUIDORES",
                alt = "TOBERAS O DISTRIBUIDORES",
                Ruta = "Imagenes/Producto/TOBERAS O DISTRIBUIDORES.jpg",
                categoria = 1,
                orden = 36
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FILTROS",
                alt = "FILTROS",
                Ruta = "Imagenes/Producto/FILTROS CARTUCHOS DE SEDIMENTO.jpg",
                categoria = 1,
                orden = 41
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "VÁLVULA AUTOMÁTICA PARA ABLANDADOR",
                alt = "VÁLVULA AUTOMÁTICA PARA ABLANDADOR",
                Ruta = "Imagenes/Producto/VÁLVULA AUTOMÁTICA PARA ABLANDADOR.jpg",
                categoria = 1,
                orden = 40
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "VÁLVULAS AUTOMÁTICAS PARA FILTROS",
                alt = "VÁLVULAS AUTOMÁTICAS PARA FILTROS",
                Ruta = "Imagenes/Producto/VÁLVULAS AUTOMÁTICAS PARA FILTROS.jpg",
                categoria = 1,
                orden = 39
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "VÁLVULAS MANUALES PARA ABLANDADOR",
                alt = "VÁLVULAS MANUALES PARA ABLANDADOR",
                Ruta = "Imagenes/Producto/VÁLVULAS MANUALES PARA ABLANDADOR.png",
                categoria = 1,
                orden = 37
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "VÁLVULAS MANUALES PARA FILTRO",
                alt = "VÁLVULAS MANUALES PARA FILTRO",
                Ruta = "Imagenes/Producto/VÁLVULAS MANUALES PARA FILTRO.png",
                categoria = 1,
                orden = 38
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "COMPARADOR DE CLORO",
                alt = "COMPARADOR DE CLORO",
                Ruta = "Imagenes/Producto/COMPARADOR DE CLORO.jpg",
                categoria = 2,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "INSTRUMENTOS DIGITALES MARCA HACH Y HANNA",
                alt = "INSTRUMENTOS DIGITALES MARCA HACH Y HANNA",
                Ruta = "Imagenes/Producto/INSTRUMENTOS DIGITALES.jpg",
                categoria = 2,
                orden = 9
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "KITS PARA ANALISIS DE AGUA",
                alt = "KITS PARA ANALISIS DE AGUA",
                Ruta = "Imagenes/Producto/KITS PARA ANALISIS DE AGUA.jpg",
                categoria = 2,
                orden = 2
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PASTILLAS DPD 1",
                alt = "PASTILLAS DPD 1",
                Ruta = "Imagenes/Producto/PASTILLAS DPD 1.jpg",
                categoria = 2,
                orden = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PASTILLAS ROJO FENOL",
                alt = "PASTILLAS ROJO FENOL",
                Ruta = "Imagenes/Producto/PASTILLAS ROJO FENOL.jpg",
                categoria = 2,
                orden = 4
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVOS QUIMICOS",
                alt = "REACTIVOS QUIMICOS",
                Ruta = "Imagenes/Producto/REACTIVOS QUIMICOS.jpg",
                categoria = 2,
                orden = 5
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "TEST DE CLORO LIBRE Y TOTAL  DPD",
                alt = "TEST DE CLORO LIBRE Y TOTAL  DPD",
                Ruta = "Imagenes/Producto/TEST DE CLORO LIBRE Y TOTAL  DPD.jpg",
                categoria = 2,
                orden = 10
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "TIRAS REACTIVAS",
                alt = "TIRAS REACTIVAS",
                Ruta = "Imagenes/Producto/TIRAS REACTIVAS.jpg",
                categoria = 2,
                orden = 6
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "INTRUMENTOS DE ENSAYO",
                alt = "INTRUMENTOS DE ENSAYO",
                Ruta = "Imagenes/Producto/5 INTRUMENTOS DE ENSAYO.jpg",
                categoria = 2,
                orden = 7
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "KIT MEDIDOR DE OZONO",
                alt = "TKIT MEDIDOR DE OZONO",
                Ruta = "Imagenes/Producto/5 KIT MEDIDOR DE OZONO.jpg",
                categoria = 2,
                orden = 8
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "MEDIDOR pH Y CONDUCTIVIDAD",
                alt = "MEDIDOR pH Y CONDUCTIVIDAD",
                Ruta = "Imagenes/Producto/5 MEDIDOR pH Y CONDUCTIVIDAD.jpg",
                categoria = 2,
                orden = 12
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "PAPEL INDICADOR DE pH",
                alt = "PAPEL INDICADOR DE pH",
                Ruta = "Imagenes/Producto/5 PAPEL INDICADOR DE pH.jpg",
                categoria = 2,
                orden = 13
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "TIRAS REACTIVAS- ACIDO PERACÉTICO",
                alt = "TIRAS REACTIVAS- ACIDO PERACÉTICO",
                Ruta = "Imagenes/Producto/5 TIRAS REACTIVAS- ACIDO PERACÉTICO.jpg",
                categoria = 2,
                orden = 11
            });



            lista.Add(new ProductosItems()
            {
                Nombre = "HIPOCLORITO DE CALCIO GRANULADO",
                alt = "Hipoclorito de calcio al 65-70% de concentración.",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "HIPOCLORITO DE SODIO",
                alt = "Hipoclorito de sodio al 7.5% de concentración.",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "CHEMFLOX-FI",
                alt = "Producto sólido granulado coagulante, clarificante de aguas turbias superficiales. Con agentes reguladores de pH.	",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SULFATO DE ALUMINA TIPO A",
                alt = "Producto sólido coagulante, clarificador de aguas turbias superficiales",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "POLIFLOC-FPL",
                alt = "Producto líquido viscoso, elaborado a base de polímeros orgánicos- Poliacrilatos Aniónicos. Empleado como auxiliar de coagulación - floculación en la clarificación de aguas turbias superficiales.",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "DIOXICHLOR-SDQ",
                alt = "Producto líquido formulado a base de DIOXIDO DE CLORO estabilizado, con HIPOCLORITOS de alta concentración. El producto resultante es un líquido homogéneo y de fácil compatibilidad con el agua cruda, y  tiene un poder desinfectante mucho mayor que los hipocloritos de sodio o de calcio",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SANICLEAN",
                alt = "Producto líquido remover de cemento, grasa, óxidos, sarro, incrustaciones calcáreas, hongos mohos, algas calcinadas y cualquier otro tipo de contaminante acumulado en determinada superficie.",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "REDOX-RPH",
                alt = "Producto líquido reductor del pH en aguas. Formulado a base de sales ácidas y fosfonatos ácidos, y cumple la función de neutralizar y regular el pH de soluciones acuosas de tendencia alcalina.",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "ALKA-PH",
                alt = "Producto líquido elevador del pH en aguas. Formulado a base de sales alcalinas,  de fácil manejo, indispensable para un óptimo tratamiento de agua y para evitar las molestias debidas a desajustes del pH. Permite aumentar y regular el pH del agua cuando este sea inferior al rango  de 7.0 –7.5. ",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "ALGISINT-25AC",
                alt = "Producto líquido empleado para el control de algas. Formulada a base de sales de amonio cuaternario de “primera generación”, el cual tiene un gran poder germicida sobre una amplia variedad de microorganismos, bacterias, hongos, algas y virus.",
                Ruta = "",
                categoria = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "CLARIFIER-CAP",
                alt = "Producto líquido viscoso tipo gel, elaborado a base de polímeros orgánicos – Poliacrilatos aniónicos, disuelto en agua. Al emplearlo en la  dosificación recomendada, tiene una acción muy rápida y eficaz de floculación, sedimentación y clarificación de la turbidez del agua.",
                Ruta = "",
                categoria = 3
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "CHEMFLOX-FI",
                alt = "Producto sólido granulado coagulante, clarificante de aguas turbias superficiales. Con agentes reguladores de pH.",
                categoria = 4,
                codigoTitulo = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SULFATO DE ALUMINA TIPO A",
                alt = "Producto sólido coagulante, clarificador de aguas turbias superficiales",
                categoria = 4,
                codigoTitulo = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "POLIFLOC-FPL",
                alt = "Producto líquido viscoso, elaborado a base de polímeros orgánicos- Poliacrilatos Aniónicos. Empleado como auxiliar de coagulación - floculación en la clarificación de aguas turbias superficiales.",
                categoria = 4,
                codigoTitulo = 1
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "HIPOCLORITO DE CALCIO GRANULADO",
                alt = "Hipoclorito de calcio al 65-70% de concentración.",
                categoria = 4,
                codigoTitulo = 2
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "HIPOCLORITO DE SODIO ",
                alt = "Hipoclorito de sodio al 7.5% de concentración.",
                categoria = 4,
                codigoTitulo = 2
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "DIOXICHLOR-SDQ",
                alt = "Producto líquido formulado a base de DIOXIDO DE CLORO estabilizado, con HIPOCLORITOS de alta concentración. El producto resultante es un líquido homogéneo y de fácil compatibilidad con el agua cruda, y  tiene un poder desinfectante mucho mayor que los hipocloritos de sodio o de calcio",
                categoria = 4,
                codigoTitulo = 2
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SANICLEAN",
                alt = "Producto líquido remover de cemento, grasa, óxidos, sarro, incrustaciones calcáreas, hongos mohos, algas calcinadas y cualquier otro tipo de contaminante acumulado en determinada superficie.",
                categoria = 4,
                codigoTitulo = 2
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "BRILTPHOS",
                alt = "Producto líquido limpiador, desengrasante, desoxidante y abrillantador de todo material en acero inoxidable.",
                categoria = 4,
                codigoTitulo = 2
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "DETERFLASH",
                alt = "Detergente líquido, no caústico, removedor de suciedad y bactericida, especial para el lavado de botellones de policarbonato, polietileno y similares en máquina lavadoras.",
                categoria = 4,
                codigoTitulo = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "DETERGRAS",
                alt = "Detergente líquido alcalino desengrasante, empleado en el lavado de forma MANUAL tanto interno como externo de botellones de policarbonato y polietileno.",
                categoria = 4,
                codigoTitulo = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "DIOXICHLOR-50DC",
                alt = "Es una solución de Dióxido de Cloro Estabilizado al 5 % de concentración. ",
                categoria = 4,
                codigoTitulo = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "DIOXICHLOR-100DC",
                alt = "Es una solución de Dióxido de Cloro Estabilizado al 10 % de concentración. ",
                categoria = 4,
                codigoTitulo = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "BIOPEROXI-DPH",
                alt = "Poderoso desinfectante, bactericida, germicida y fungicida de amplio espectro, formulado a base de Peróxidos, así como iones de Plata (Ag+), donde el Peróxido de Hidrógeno es el más influyente (H2O2). Tiene una alta concentración y es muy activo contra los microorganismos patógenos diversos.",
                categoria = 4,
                codigoTitulo = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PROXITANE-15AP",
                alt = "Ácido Peracético al 15%",
                categoria = 4,
                codigoTitulo = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PEROXIDIAL",
                alt = "Producto líquido de gran acción desinfectante, bactericida, germicida, fungicida y virucida. El producto está formulado a base de Ácido Peracético, Peróxido de Hidrógeno y Ácido Acético.",
                categoria = 4,
                codigoTitulo = 3
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "BRILTPLAST",
                alt = "Producto líquido abrillantador de envases plásticos PET, PVC o policarbonato donde se almacena y traslada agua de mesa para consumo humano.",
                categoria = 4,
                codigoTitulo = 4
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "OSMO-PLUSS 0100",
                alt = "Es un anti-incrustante, que se utiliza en los sistemas de Ósmosis Inversa, para mantener en suspensión las sales de carbonato de calcio y de magnesio, hidróxidos metálicos y sales de metales pesados que contiene el agua, evitando que estas se depositen sobre la superficie de las membranas, las cuales causarían incrustaciones y como tal reducción en la cantidad y calidad de agua como producto.",
                categoria = 4,
                codigoTitulo = 5
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "DESINCRUST",
                alt = "Producto líquido de raíz ácida. Se utiliza para realizar una limpieza química de desincrustación y remoción de sales y materia orgánica de las membranas osmóticas, con la finalidad de mantenerlas en buen estado de operación y conservarlas por largos periodos.",
                categoria = 4,
                codigoTitulo = 5
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "OSMOKAL",
                alt = "Producto líquido alcalino. Se emplea en la limpieza profunda de las membranas de los equipos de Osmosis Inversa, en un segundo paso. Para una limpieza normal de membranas, emplear una solución al 2 % del producto, preparado con agua osmotizada.",
                categoria = 4,
                codigoTitulo = 5
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "",
                alt = "-CEPILLOS PARA LAVADO </br>-FILTROS CARTUCHOS DE SEDIMENTOS </br>-FILTROS CARTUCHOS DE CARBON ACTIVADO </br>-ACCESORIOS Y REPUESTOS VARIOS </br>-VER RUBRO MATERIALES Y ACCESORIOS PARA TRATAMIENTO DE AGUA",
                categoria = 4,
                codigoTitulo = 6
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 50,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN REGULADORA BUFFER PH-10",
                alt = "D-1",
                categoria = 9,
                codigoTitulo = 50
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA DE NEGRO DE ERIOCROMO T       (=)",
                alt = "D-2",
                categoria = 9,
                codigoTitulo = 50
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO INDICADOR EN POLVO DE NEGRO DE ERIOCROMO T   (=)",
                alt = "D-2",
                categoria = 9,
                codigoTitulo = 50
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE DE E.D.T.A 0.02 N",
                alt = "D-3",
                categoria = 9,
                codigoTitulo = 50
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 51,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN REGULADORA 0.1 N",
                alt = "CA-1",
                categoria = 9,
                codigoTitulo = 51
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO INDICADOR EN POLVO DE MUREXIDA",
                alt = "CA-2",
                categoria = 9,
                codigoTitulo = 51
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE DE E.D.T.A 0.02 N",
                alt = "CA-3",
                categoria = 9,
                codigoTitulo = 51
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 52,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA DE FENOLFTALEINA AL 1.0%",
                alt = "A-1",
                categoria = 9,
                codigoTitulo = 52
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE INDICADOR MIXTO           (=)",
                alt = "A-2",
                categoria = 9,
                codigoTitulo = 52
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE ANARANJADO DE METILO           (=)",
                alt = "A-2",
                categoria = 9,
                codigoTitulo = 52
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE DE ÁCIDO 0.02 N",
                alt = "A-3",
                categoria = 9,
                codigoTitulo = 52
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 53,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN REGULADORA ÁCIDA 1.0 N",
                alt = "S-1",
                categoria = 9,
                codigoTitulo = 53
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA DE ALMIDÓN AL 1.0 %",
                alt = "S-2",
                categoria = 9,
                codigoTitulo = 53
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE DE IODATO / IODURO DE POTASIO 0.0125 N",
                alt = "S-3",
                categoria = 9,
                codigoTitulo = 53
            });



            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 54,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN REGULADORA ÁCIDA 0.05 N",
                alt = "C-1",
                categoria = 9,
                codigoTitulo = 54
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA DE CROMATO DE POTASIO AL 5.0 %",
                alt = "C-2",
                categoria = 9,
                codigoTitulo = 54
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE DE NITRATO DE PLATA 0.0171 N",
                alt = "C-3",
                categoria = 9,
                codigoTitulo = 54
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 55,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA DE FENOLFTALEINA L 1.0%",
                alt = "AT-1",
                categoria = 9,
                codigoTitulo = 55
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE DE HIDRÓXIDO DE POTASIO 0.1 N           (=)",
                alt = "AT-2",
                categoria = 9,
                codigoTitulo = 55
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE ALCALINA 0.1 N           (=)",
                alt = "AT-2",
                categoria = 9,
                codigoTitulo = 55
            });

            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 56,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN REACTIVA INDIRECTA CLORO-1",
                alt = "CL-1",
                categoria = 9,
                codigoTitulo = 56
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN REGULADORA DE PH CLORO-2",
                alt = "CL-2",
                categoria = 9,
                codigoTitulo = 56
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA CLORO-3",
                alt = "CL-3",
                categoria = 9,
                codigoTitulo = 56
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN TITULANTE CLORO-4CL",
                alt = "CL-4",
                categoria = 9,
                codigoTitulo = 56
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 57,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE ÁCIDO ACÉTICO Q.P.",
                alt = "DCL-1",
                categoria = 9,
                codigoTitulo = 57
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE IODURO DE POTASIO",
                alt = "DCL-2",
                categoria = 9,
                codigoTitulo = 57
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA DE ALMIDÓN",
                alt = "DCL-3",
                categoria = 9,
                codigoTitulo = 57
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE TIOSULFATO DE SODIO",
                alt = "DCL-4",
                categoria = 9,
                codigoTitulo = 57
            });


            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVO",
                alt = "CÓDIGO",
                categoria = 9,
                codigoTitulo = 58,
                orden = 1
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE ÁCIDO FOSFÓRICO Q.P.",
                alt = "PH-1",
                categoria = 9,
                codigoTitulo = 58
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE IODURO DE POTASIO",
                alt = "PH-2",
                categoria = 9,
                codigoTitulo = 58
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN INDICADORA DE ALMIDÓN",
                alt = "PH-3",
                categoria = 9,
                codigoTitulo = 58
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "SOLUCIÓN DE TIOSULFATO DE SODIO",
                alt = "PH-4",
                categoria = 9,
                codigoTitulo = 58
            });

            return lista;
        }
        public static List<ProductosItemsTitulo> ListProductosTitulos()
        {
            List<ProductosItemsTitulo> lista = new List<ProductosItemsTitulo>();

            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "TRATAMIENTO DE AGUA",
                codigo = 1,
                orden = 1
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DESINFECCION DE AGUA, PLANTA Y EQUIPOS",
                codigo = 2,
                orden = 2
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERGENTE Y DESINFECTANTE PARA EL LAVADO",
                codigo = 3,
                orden = 3
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "ABRILLANTADOR EXTERNO DE BOTELLONES PET, PVC Y POLICARBONATO",
                codigo = 4,
                orden = 4
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "LIMPIEZA DE MEMBRANAS DE ÓSMOSIS INVERSA",
                codigo = 5,
                orden = 5
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "ACCESORIOS Y PRODUCTOS VARIOS:",
                codigo = 6,
                orden = 6
            });

            return lista;
        }
        public static List<ProductosItemsTitulo> ListProductosReactivos()
        {
            List<ProductosItemsTitulo> lista = new List<ProductosItemsTitulo>();

            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE DUREZA TOTAL EN AGUAS",
                codigo = 50,
                orden = 1
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE DUREZA CALCICA EN AGUAS",
                codigo = 51,
                orden = 2
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE ALCALINIDADES EN AGUAS",
                codigo = 52,
                orden = 3
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE SULFITOS EN AGUAS",
                codigo = 53,
                orden = 4
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE CLORUROS EN AGUAS",
                codigo = 54,
                orden = 5
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE ACIDEZ TITULABLE",
                codigo = 55,
                orden = 6
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE CLORO ACTIVO",
                codigo = 56,
                orden = 7
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE DIOXIDO DE CLORO",
                codigo = 57,
                orden = 8
            });
            lista.Add(new ProductosItemsTitulo()
            {
                TituloPrincipal = "DETERMINACIÓN DE PERÓXIDO DE HIDRÓGENO",
                codigo = 58,
                orden = 9
            });

            return lista;
        }
        public class ProductosItems
        {
            public string Ruta { get; set; }
            public string Nombre { get; set; }
            public string alt { get; set; }
            public int categoria { get; set; }
            public int codigoTitulo { get; set; }
            public int orden { get; set; }
        }
        public class ProductosItemsTitulo
        {
            public string TituloPrincipal { get; set; }
            public int codigo { get; set; }
            public int orden { get; set; }
        }
    }
}
