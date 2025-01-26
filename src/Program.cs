﻿using BomRoutingApp;

try
{
    var result = FileWorker.ReadSourceFiles<BomItem, RoutingStep>();

    var bom = (BomItem)result["bom"];
    var routing = (List<RoutingStep>)result["routing"];

    var providedComponents = new Dictionary<string, int>();

    Report.GetSumQuantity(bom, providedComponents);

    FileWorker.WriteOutputFile(providedComponents);
}
catch (System.Exception ex)
{
    ConsoleMessage.DisplayError($"Error: {ex.Message}");
    Environment.Exit(1);
}


