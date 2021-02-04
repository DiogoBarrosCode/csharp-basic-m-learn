/* exibir msg de permissão de acesso */

/* este desafio, você implementará regras de negócios que restringem
 o acesso a usuários com base nas respectivas permissões e nível.
Você exibirá uma mensagem diferente para cada usuário, dependendo 
das respectivas permissões e nível. */

string[] permission = {"Admin", "Manager"};
int level = 56;

string permissionAccess = permission[0];
//Console.WriteLine(permissionAcess);

/*
foreach(string permissionAcess in permission){
    Console.WriteLine(permissionAcess);
}
*/

if (permissionAccess.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permissionAccess.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}