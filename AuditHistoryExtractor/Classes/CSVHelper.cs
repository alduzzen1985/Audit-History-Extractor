using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes
{
    public static class CSVHelper
    {
        private const string ErrorMessageUnableToWrite = "It is not possible to write the file, ensure that the file isn't being used by another program.";
        


        private static CsvWriter csvWriter;

        public static void WriteFile(string fileName, string delimiter, string identificatorField, List<AuditHistory> lsAuditHistory)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    csvWriter = new CsvWriter(writer);
                    csvWriter.Configuration.Delimiter = delimiter;
                    csvWriter.Configuration.QuoteAllFields = true;
                    csvWriter.Configuration.RegisterClassMap(new AuditHistoryRecordMap(identificatorField));
                    csvWriter.WriteRecords(lsAuditHistory); // where values implements IEnumerable
                }
            }
            catch
            {
                throw new Exception(ErrorMessageUnableToWrite);
            }
        }
    }
}
