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
                Nombre = "FILTROS",
                alt = "FILTROS",
                Ruta = "Imagenes/Producto/MANGUERAS DE POLIETILENO.jpg",
                categoria = 1,
                orden = 24
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "FILTROS",
                alt = "FILTROS",
                Ruta = "Imagenes/Producto/MANGUERAS DE POLIETILENO.jpg",
                categoria = 1,
                orden = 25
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
                orden = 28
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
                orden = 32
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
                orden = 40
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
                orden = 38
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
                orden = 36
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "VÁLVULAS MANUALES PARA FILTRO",
                alt = "VÁLVULAS MANUALES PARA FILTRO",
                Ruta = "Imagenes/Producto/VÁLVULAS MANUALES PARA FILTRO.png",
                categoria = 1,
                orden = 37
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
                Nombre = "INSTRUMENTOS DIGITALES",
                alt = "INSTRUMENTOS DIGITALES",
                Ruta = "Imagenes/Producto/INSTRUMENTOS DIGITALES.jpg",
                categoria = 2,
                orden = 2
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "KITS PARA ANALISIS DE AGUA",
                alt = "KITS PARA ANALISIS DE AGUA",
                Ruta = "Imagenes/Producto/KITS PARA ANALISIS DE AGUA.jpg",
                categoria = 2,
                orden = 3
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PASTILLAS DPD 1",
                alt = "PASTILLAS DPD 1",
                Ruta = "Imagenes/Producto/PASTILLAS DPD 1.jpg",
                categoria = 2,
                orden = 4
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "PASTILLAS ROJO FENOL",
                alt = "PASTILLAS ROJO FENOL",
                Ruta = "Imagenes/Producto/PASTILLAS ROJO FENOL.jpg",
                categoria = 2,
                orden = 5
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "REACTIVOS QUIMICOS",
                alt = "REACTIVOS QUIMICOS",
                Ruta = "Imagenes/Producto/REACTIVOS QUIMICOS.jpg",
                categoria = 2,
                orden = 6
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "TEST DE CLORO LIBRE Y TOTAL  DPD",
                alt = "TEST DE CLORO LIBRE Y TOTAL  DPD",
                Ruta = "Imagenes/Producto/TEST DE CLORO LIBRE Y TOTAL  DPD.jpg",
                categoria = 2,
                orden = 8
            });
            lista.Add(new ProductosItems()
            {
                Nombre = "TIRAS REACTIVAS",
                alt = "TIRAS REACTIVAS",
                Ruta = "Imagenes/Producto/TIRAS REACTIVAS.jpg",
                categoria = 2,
                orden = 7
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
                Nombre = "PEROXITANE-15AP",
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
