using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    class Program
    {
        static void Main(string[] args)
        {
            //String div = HtmlParser.ObtemConteudoElementoHtml(html: "<div><span>Teste1</span><span class=\"teste123\">Teste3</span></div><div>Teste2</div>", tag: "div");
            //String primeiroSpan = HtmlParser.ObtemConteudoElementoHtml(div, "span");
            //String spanComClass = HtmlParser.ObtemConteudoElementoHtml(div, "span class=");
            //String propSpanComClass = HtmlParser.ObtemPropriedadeElementoHtml(div, "span class=", "class");
            //Console.WriteLine(div);
            //Console.WriteLine(primeiroSpan);
            //Console.WriteLine(spanComClass);
            //Console.WriteLine(propSpanComClass);

            String htmlPiada = "<article class=\"item - index\">< div class=\"row\"><div class=\"col-xs-12\"><h4><a href = \"/piadas/chegando-bebado-em-casa-21278.html\" > Chegando Bêbado Em Casa</a></h4></div></div><div class=\"row\"><div class=\"col-xs-9 col-sm-10\"><div class=\"joke\"><p>Um homem chega bêbado em casa, a sua mulher nervosa pergunta:</p><p>- Você bebeu de novo?</p><p>- Claro que não, filhão!</p></div><footer><div class=\"created-info\"><span class=\"created-by\">Por<strong> Brasil depressivo</strong></span><span class=\"created-at\"><a href = \"/piadas/chegando-bebado-em-casa-21278.html\" >< time datetime=\"2017-10-13T21:17:46-03:00\">13/10/2017 21:17</time></a></span></div><div class=\"tag-list\"><ul class=\"list-inline\"><li><a href = \"/piadas/bebados/\" > Piadas de Bêbados</a></li><li><a href = \"/piadas/curtas/\" > Piadas Curtas</a></li></ul></div></footer></div><div class=\"col-xs-3 col-sm-2\"><div class=\"votes\" data-url=\"/api/piadas/votar/21278/\"><div class=\"vote-up\"></div><div class=\"stats-up\">154</div><div class=\"score\">-188</div><div class=\"stats-down\">342</div><div class=\"vote-down\"></div></div></div></div></article>";
            Piada piada = new Piada(htmlPiada);
            Console.Write(piada);
        }
    }
}
