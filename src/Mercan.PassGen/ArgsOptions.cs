using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandLine;

namespace Mercan.PassGen
{
    public class ArgsOptions
    {


          [Value(0, MetaName = "min",Required =true, HelpText = "Min Length")]
          public int MinLength { get; set; }


        [Value(1, MetaName = "max",Required =true ,HelpText = "Max Length")]
        public int MaxLength { get; set; }


        [Option('s', "excludesymbols", Required = false, HelpText = "Exclude Symbols from generated Password ?")]
        public bool ExcludeSymbols { get; set; }

        [Option('e', "excludes", Required = false, HelpText = "Exclude Characters from generated Password ")]
        public string Excludes { get; set; }

    }
}
