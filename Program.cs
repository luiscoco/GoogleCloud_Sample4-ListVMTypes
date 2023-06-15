using Google.Cloud.Compute.V1;

// Instantiate the MachineTypesClient and ImagesClient
MachineTypesClient machineTypesClient = MachineTypesClient.Create();
ImagesClient imagesClient = ImagesClient.Create();

// List machine types
var machineTypesList = machineTypesClient.List(new ListMachineTypesRequest
{
    Project = "focus-cache-387205",
    Zone = "europe-southwest1-a"
});

Console.WriteLine("Machine Types:");
foreach (MachineType machineType in machineTypesList)
{
    Console.WriteLine($"- {machineType.Name}");
}

Console.WriteLine();