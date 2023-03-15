using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDtester.i18n
{
    internal class I18nEs : I18n
    {
        public override string Lang => "es";
        public override string ButtonGo => "Go";
        public override string ButtonCancel => "Cancelar";
        public override string StatusGoHint => "Pulsa [Go] para empezar.";
        public override string StatusStarting => "Iniciando...";
        public override string StatusWriting => "Escribiendo";
        public override string StatusVerifying => "Verificando";
        public override string StatusCancelled => "Cancelado:";
        public override string LabelDrive => "Unidad:";
        public override string LabelExplain => "No se modificará ningún dato, las partes ocupadas no se probarán, se recomienda que la unidad esté lo más vacía posible.";
        public override string LabelWriteSpeed => "Velocidad escritura:";
        public override string LabelReadSpeed => "Velocidad lectura:";
        public override string MsgValidErrorTitle => "Error de validación";
        public override string MsgValidErrorText => "Se han encontraod errores al validar la tarjeta.\r\n¿Desea conservar el archivo de pruebas para analizarlo?";
        public override string AboutTitle => "Acerca de Sd Tester";
        public override string AboutText => "Comprueba la fiabilidad de la SD generando un archivo que ocupa el espacio vacío y verificandolo despues.";
        public override string AboutTranslation => "Idioma por XWolf Override.";


    }
}
