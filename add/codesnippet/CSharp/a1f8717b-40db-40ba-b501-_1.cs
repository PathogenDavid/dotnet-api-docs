      myServiceDescription = 
         ServiceDescription.Read("StockQuoteService_cs.wsdl");
      myServiceDescription.Imports.Insert(
         0,CreateImport("http://localhost/stockquote/definitions",
         "http://localhost/stockquote/stockquote_cs.wsdl"));