using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Processor {

    public static class ProcessorFactory {

        public static AbstractProcessor Create(long changeAmount) {

            AbstractProcessor[] processorList = new AbstractProcessor[] {       
                new CoinProcessor(),
                new BillProcessor()

                // TODO: Adicionar novos processadores acima desta linha.
            };

            // Ordena a lista a partir do menor valor disponível.
            processorList = processorList.OrderByDescending(p => p.GetAvailableValues().Min()).ToArray();

            // Verifica cada processador e tenta encontrar o primeiro que tenha um valor capaz de calcular o troco.
            foreach (AbstractProcessor processor in processorList) {

                if (processor.GetAvailableValues().Min() <= changeAmount) { return processor; }
            }

            return null;
        }
    }
}
