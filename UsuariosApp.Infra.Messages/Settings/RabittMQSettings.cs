using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Infra.Messages.Settings
{
    /// <summary>
    /// Classe para mapear / configurar as informações de conexão
    /// com o servidor da mensageria e com a fila que iremos acessar
    /// </summary>
    public class RabbitMQSettings
    {
        /// <summary>
        /// Caminho para conexão com o servidor da mensageria
        /// </summary>
        public static string Url => "amqps://rfnyoyyn:CTLc2H22_EL7woRuR1K28N-NbmFDFKiQ@gull.rmq.cloudamqp.com/rfnyoyyn"; // cipia do AMQP details


        /// <summary>
        /// Nome da fila que iremos acessar no servidor
        /// </summary>
        public static string Queue => "mensagens_email";  // pode ser qq nome
    }
}