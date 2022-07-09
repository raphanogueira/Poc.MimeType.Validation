using Microsoft.AspNetCore.StaticFiles;

while (true)
{
    Console.WriteLine("Informe a extensão: ");
    var extension = Console.ReadLine();

    var base64MimeType = "data:application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

    var hasContentType = new FileExtensionContentTypeProvider().TryGetContentType($".{extension}", out var mimeContentType);

    if (hasContentType && base64MimeType!.Contains(mimeContentType))
        Console.WriteLine("A extensão é igual ao base64");

    else
        Console.WriteLine("A extensão é diferente do base64");
}