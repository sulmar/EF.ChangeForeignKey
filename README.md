# Przykład zmiany nazwy klucza obcego

## Za pomocą migracji

W migracji możemy w ForeignKey możemy podać własną nazwę relacji.

~~~ csharp

 CreateTable(

                "dbo.ClientAddresses",

                c => new

                    {

                        ClientAddressId = c.Int(nullable: false, identity: true),

                        Street = c.String(),

                        City = c.String(),

                        Client_ClientId = c.Int(),

                    })

                .PrimaryKey(t => t.ClientAddressId)

                .ForeignKey("dbo.Clients", t => t.Client_ClientId, cascadeDelete:true, name:"FK_Client_Address")

                .Index(t => t.Client_ClientId);
                
                ~~~

