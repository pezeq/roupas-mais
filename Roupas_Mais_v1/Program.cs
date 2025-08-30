namespace Roupas_Mais_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validEntry = true;
            bool useLoadProducts = true;

            string[,] productsTable = new string[100, 4];
            int productIndex = 0;

            string[,] salesTable = new string[100, 4];
            int saleIndex = 0;

            do
            {
                PrintHeader();
                string menuOption = Menu();

                switch (menuOption)
                {
                    case "0":
                        validEntry = SystemShutdown();
                        break;

                    case "1":
                        RunRegisterProduct(productsTable, useLoadProducts, productIndex);
                        productIndex++;
                        break;

                    case "2":
                        RunRegisterSale(salesTable, productsTable, saleIndex);
                        saleIndex++;
                        break;

                    case "3":
                        RunSalesReport(salesTable);
                        break;

                    case "4":
                        RunEmployeeReport(salesTable);
                        break;

                    case "5":
                        RunStockReport(productsTable);
                        break;

                    case "6":
                        RunUpdateProduct(productsTable);
                        break;

                    case "7":
                        RunDeleteProduct(productsTable);
                        break;

                    default:
                        Console.WriteLine("\nOPÇÃO INVÁLIDA!");
                        break;
                }

                if (menuOption != "0")
                {
                    Console.WriteLine("\nPRESSIONE ALGUMA TECLA PARA CONTINUAR...");
                    Console.ReadKey();
                }

            } while (validEntry);
        }

        // => MÉTODOS : MENU

        static void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine(@"//////////////////////////////////////////////////////////////////////////////////
//                                                                              //
//   ███████████                                                                //
//  ░░███░░░░░███                                                      ███      //
//   ░███    ░███   ██████  █████ ████ ████████   ██████    █████     ░███      //
//   ░██████████   ███░░███░░███ ░███ ░░███░░███ ░░░░░███  ███░░   ███████████  //
//   ░███░░░░░███ ░███ ░███ ░███ ░███  ░███ ░███  ███████ ░░█████ ░░░░░███░░░   //
//   ░███    ░███ ░███ ░███ ░███ ░███  ░███ ░███ ███░░███  ░░░░███    ░███      //
//   █████   █████░░██████  ░░████████ ░███████ ░░████████ ██████     ░░░       //
//  ░░░░░   ░░░░░  ░░░░░░    ░░░░░░░░  ░███░░░   ░░░░░░░░ ░░░░░░                //
//                                     ░███                                     //
//                                     █████                                    //
//                                    ░░░░░                                     //
//                                                                              //
//////////////////////////////////////////////////////////////////////////////////
powered by pedro ezequiel | @pezeq | e/s.                               versão 1.0
");
        }

        static string Menu()
        {
            Console.WriteLine("( 1 ) REGISTRAR PRODUTO");
            Console.WriteLine("( 2 ) REALIZAR UMA VENDA");
            Console.WriteLine("( 3 ) RELATÓRIO VENDAS");
            Console.WriteLine("( 4 ) RELATÓRIO FUNCIONÁRIO");
            Console.WriteLine("( 5 ) VERIFICAR ESTOQUE");
            Console.WriteLine("( 6 ) ATUALIZAR PRODUTO");
            Console.WriteLine("( 7 ) DELETAR PRODUTO");
            Console.WriteLine("( 0 ) SAIR");
            Console.Write("\nSELECIONE UMA OPÇÃO: ");
            string menuOption = Console.ReadLine();

            return menuOption;
        }

        static bool SystemShutdown()
        {
            Console.Clear();
            Console.WriteLine("ENCERRANDO SISTEMA...");
            return false;
        }

        static void RunRegisterProduct(string[,] productsTable, bool useLoadProducts, int productIndex)
        {
            Console.Clear();
            if (useLoadProducts)
            {
                Console.WriteLine("+------------------------------------------------------------------------------+");
                Console.WriteLine("| AVISO: 'useLoadProducts' ATIVADO! CARREGANDO LISTA DE PRODUTOS PARA TESTE... |");
                Console.WriteLine("+------------------------------------------------------------------------------+");
                productsTable = LoadProducts(productsTable);
            }
            else
            {
                Console.WriteLine("+---------------------+");
                Console.WriteLine("| REGISTRANDO PRODUTO |");
                Console.WriteLine("+---------------------+\n");
                RegisterProduct(productsTable, productIndex);
            }
        }

        static void RunRegisterSale(string[,] salesTable, string[,] productsTable, int saleIndex)
        {
            Console.Clear();
            Console.WriteLine("+-------------------+");
            Console.WriteLine("| REGISTRANDO VENDA |");
            Console.WriteLine("+-------------------+\n");
            RegisterSale(salesTable, productsTable, saleIndex);
        }

        static void RunSalesReport(string[,] salesTable)
        {
            Console.Clear();
            Console.WriteLine("+------------------+");
            Console.WriteLine("| RELATÓRIO VENDAS |");
            Console.WriteLine("+------------------+\n");
            SalesReport(salesTable);
        }

        static void RunEmployeeReport(string[,] salesTable)
        {
            Console.Clear();
            Console.WriteLine("+-----------------------+");
            Console.WriteLine("| RELATÓRIO FUNCIONÁRIO |");
            Console.WriteLine("+-----------------------+\n");
            EmployeeReport(salesTable);
        }

        static void RunStockReport(string[,] productsTable)
        {
            Console.Clear();
            Console.WriteLine("+---------------------+");
            Console.WriteLine("| VERIFICANDO ESTOQUE |");
            Console.WriteLine("+---------------------+\n");
            StockReport(productsTable);
        }

        static void RunUpdateProduct(string[,] productsTable)
        {
            Console.Clear();
            Console.WriteLine("+---------------------+");
            Console.WriteLine("| ATUALIZANDO PRODUTO |");
            Console.WriteLine("+---------------------+\n");
            UpdateProduct(productsTable);
        }

        static void RunDeleteProduct(string[,] productsTable)
        {
            Console.Clear();
            Console.WriteLine("+-------------------+");
            Console.WriteLine("| DELETANDO PRODUTO |");
            Console.WriteLine("+-------------------+\n");
            DeleteProduct(productsTable);
        }

        //  => MÉTODOS : REGISTRADORES.

        static string[,] LoadProducts(string[,] productsTable)
        {
            for (int i = 0; i < productsTable.GetLength(0); i++)
            {
                switch (i)
                {
                    case 0:
                        productsTable[i, 0] = "1";
                        productsTable[i, 1] = "Blusa";
                        productsTable[i, 2] = "20,00";
                        productsTable[i, 3] = "45";
                        break;

                    case 1:
                        productsTable[i, 0] = "2";
                        productsTable[i, 1] = "Calça";
                        productsTable[i, 2] = "90,00";
                        productsTable[i, 3] = "100";
                        break;

                    case 2:
                        productsTable[i, 0] = "3";
                        productsTable[i, 1] = "Meia";
                        productsTable[i, 2] = "10,00";
                        productsTable[i, 3] = "55";
                        break;
                }
            }
            return productsTable;
        }

        static void RegisterProduct(string[,] productsTable, int productIndex)
        {
            if (productIndex >= productsTable.GetLength(0))
            {
                Console.WriteLine("LIMITE DE PRODUTOS ATINGIDO!");
                return;
            }

            int productCode = SetProductCode();
            string productDescription = SetProductDescription();
            double productValue = SetProductValue();
            int productQuantity = SetProductQuantity();

            if (VerifyRegisterProduct(
                productsTable,
                productCode,
                productValue,
                productQuantity
            ))
            {
                productsTable[productIndex, 0] = productCode.ToString();
                productsTable[productIndex, 1] = productDescription;
                productsTable[productIndex, 2] = productValue.ToString();
                productsTable[productIndex, 3] = productQuantity.ToString();

                Console.WriteLine("\nPRODUTO REGISTRADO COM SUCESSO!");
            }
        }

        static void RegisterSale(string[,] salesTable, string[,] productsTable, int saleIndex)
        {
            if (saleIndex >= salesTable.GetLength(0))
            {
                Console.WriteLine("LIMITE DE VENDAS ATINGIDO!");
                return;
            }

            int productCode = SetProductCode();
            int employeeCode = SetEmployeeCode();
            int quantitySold = SetQuantitySold();

            int productIndex = GetProductIndex(productsTable, productCode);
            int stockQuantity = GetStockQuantity(productsTable, productCode);

            if (VerifyRegisterSale(
                productsTable,
                productCode,
                quantitySold,
                employeeCode,
                productIndex,
                stockQuantity
            ))
            {
                double productValue = Convert.ToDouble(productsTable[productIndex, 2]);
                double saleValue = productValue * quantitySold;

                salesTable[saleIndex, 0] = productCode.ToString();
                salesTable[saleIndex, 1] = employeeCode.ToString();
                salesTable[saleIndex, 2] = quantitySold.ToString();
                salesTable[saleIndex, 3] = saleValue.ToString();

                int updatedStockQuantity = stockQuantity - quantitySold;
                productsTable[productIndex, 3] = updatedStockQuantity.ToString();

                Console.WriteLine("\nVENDA REGISTRADA COM SUCESSO!");
            }
        }

        //  => MÉTODOS : RELATÓRIOS.

        static void SalesReport(string[,] salesTable)
        {
            double totalSalesValue = 0.0;

            PrintReportHeader(1);

            for (int i = 0; i < salesTable.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(salesTable[i, 0]))
                {
                    string productCode = salesTable[i, 0];
                    string employeeCode = salesTable[i, 1];
                    string quantitySold = salesTable[i, 2];
                    double saleValue = Convert.ToDouble(salesTable[i, 3]);
                    string formattedSaleValue = saleValue.ToString("C");
                    totalSalesValue += saleValue;

                    PrintReportRow(
                        productCode,
                        employeeCode,
                        quantitySold,
                        formattedSaleValue,
                        1
                    );
                }
            }

            PrintReportTotal(totalSalesValue);
        }

        static void EmployeeReport(string[,] salesTable)
        {
            string employeeCode = SetEmployeeCode().ToString();
            double totalSalesValue = 0.0;

            Console.WriteLine();

            PrintReportHeader(1);

            for (int i = 0; i < salesTable.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(salesTable[i, 0]))
                {
                    if (salesTable[i, 1].Equals(employeeCode))
                    {
                        string productCode = salesTable[i, 0];
                        employeeCode = salesTable[i, 1];
                        string quantitySold = salesTable[i, 2];
                        double saleValue = Convert.ToDouble(salesTable[i, 3]);
                        string formattedSaleValue = saleValue.ToString("C");
                        totalSalesValue += saleValue;

                        PrintReportRow(
                            productCode,
                            employeeCode,
                            quantitySold,
                            formattedSaleValue,
                            1
                        );
                    }
                }
            }

            PrintReportTotal(totalSalesValue);
            PrintReportCommission(totalSalesValue);
        }

        static void StockReport(string[,] productsTable)
        {
            PrintReportHeader(2);

            for (int i = 0; i < productsTable.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(productsTable[i, 0]))
                {
                    string productCode = productsTable[i, 0];
                    string productDescription = productsTable[i, 1];
                    double productValue = Convert.ToDouble(productsTable[i, 2]);
                    string formattedProductValue = productValue.ToString("C");
                    string productQuantity = productsTable[i, 3];

                    PrintReportRow(
                        productCode,
                        productDescription,
                        formattedProductValue,
                        productQuantity,
                        2
                    );
                }
            }
        }

        static void PrintReportHeader(int headerOption)
        {
            if (headerOption == 1)
            {
                Console.WriteLine("+--------------+----------------+--------------+-----------------+");
                Console.WriteLine($"| {"CÓDIGO:".PadRight(12)} | {"FUNCIONÁRIO:".PadRight(14)} | {"QTD.:".PadRight(12)} | {"VALOR DA VENDA:".PadRight(14)} |");
                Console.WriteLine("+--------------+----------------+--------------+-----------------+");
            }

            if (headerOption == 2)
            {
                Console.WriteLine("+--------------+--------------------------+----------------+--------------+");
                Console.WriteLine($"| {"CÓDIGO:".PadRight(12)} | {"DESCRIÇÃO:".PadRight(24)} | {"VALOR:".PadRight(14)} | {"QTD.:".PadRight(12)} |");
                Console.WriteLine("+--------------+--------------------------+----------------+--------------+");
            }
        }

        static void PrintReportRow(string firstColumn, string secondColumn, string thirdColumn, string fourthColumn, int rowOption)
        {
            if (rowOption == 1)
            {
                Console.WriteLine($"| {firstColumn.PadRight(12)} | {secondColumn.PadRight(14)} | {thirdColumn.PadRight(12)} | {fourthColumn.PadRight(15)} |");
                Console.WriteLine("+--------------+----------------+--------------+-----------------+");
            }

            if (rowOption == 2)
            {
                Console.WriteLine($"| {firstColumn.PadRight(12)} | {secondColumn.PadRight(24)} | {thirdColumn.PadRight(14)} | {fourthColumn.PadRight(12)} |");
                Console.WriteLine("+--------------+--------------------------+----------------+--------------+");
            }
        }

        static void PrintReportTotal(double totalSalesValue)
        {
            Console.WriteLine($"| {"TOTAL".PadRight(44)} : {totalSalesValue.ToString("C").PadRight(15)} |");
            Console.WriteLine("+----------------------------------------------------------------+");
        }

        static void PrintReportCommission(double totalSalesValue)
        {
            Console.WriteLine($"| {"COMISSÃO (10%)".PadRight(44)} : {(totalSalesValue * 0.10).ToString("C").PadRight(15)} |");
            Console.WriteLine("+----------------------------------------------------------------+");
        }

        //  => MÉTODOS : ATUALIZAR.

        static void UpdateProduct(string[,] productsTable)
        {
            int productCode = SetProductCode();
            int productIndex = GetProductIndex(productsTable, productCode);

            if (VerifyProductIndex(productCode, productIndex))
            {
                string updateOption = UpdateProductOptions();

                ApplyUpdateProduct(
                    productsTable,
                    updateOption,
                    productCode,
                    productIndex
                );
            }
        }

        static string UpdateProductOptions()
        {
            Console.WriteLine("\nO QUE DESEJA ATUALIZAR?");
            Console.WriteLine("( 1 ) DESCRIÇÃO DO PRODUTO");
            Console.WriteLine("( 2 ) PREÇO DO PRODUTO");
            Console.WriteLine("( 3 ) ADICIONAR ESTOQUE");
            Console.Write("\nSELECIONE UMA OPÇÃO: ");
            string updateOption = Console.ReadLine();

            return updateOption;
        }

        static void ApplyUpdateProduct(
            string[,] productsTable,
            string updateOption,
            int productCode,
            int productIndex
        )
        {
            Console.WriteLine();

            switch (updateOption)
            {
                case "1":
                    string productDescription = SetProductDescription();
                    productsTable[productIndex, 1] = productDescription;

                    Console.WriteLine("\nPRODUTO ATUALIZADO COM SUCESSO!");
                    break;

                case "2":
                    double productValue = SetProductValue();

                    if (productValue < 1)
                    {
                        Console.WriteLine("\nERROR: Valor minímo do produto é de R$ 1,00!");
                        return;
                    }

                    productsTable[productIndex, 2] = productValue.ToString();

                    Console.WriteLine("\nPRODUTO ATUALIZADO COM SUCESSO!");
                    break;

                case "3":
                    int productQuantity = SetProductQuantity();

                    if (productQuantity < 1)
                    {
                        Console.WriteLine("\nERROR: Adicione ao menos 1 unidade no estoque!");
                        return;
                    }

                    int stockQuantity = GetStockQuantity(productsTable, productCode);
                    int updateStockQuantity = stockQuantity + productQuantity;
                    productsTable[productIndex, 3] = updateStockQuantity.ToString();

                    Console.WriteLine("\nPRODUTO ATUALIZADO COM SUCESSO!");
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
            }
        }

        //  => MÉTODOS : DELETAR.

        static void DeleteProduct(string[,] productsTable)
        {
            int productCode = SetProductCode();
            int productIndex = GetProductIndex(productsTable, productCode);

            if (VerifyProductIndex(productCode, productIndex))
            {
                ApplyDeleteProduct(productsTable, productIndex);
                Console.WriteLine("\nPRODUTO DELETADO COM SUCESSO!");
            }
        }

        static void ApplyDeleteProduct(string[,] productsTable, int productIndex)
        {
            int rows = productsTable.GetLength(0);
            int cols = productsTable.GetLength(1);

            for (int i = productIndex + 1; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    productsTable[i - 1, j] = productsTable[i, j];
                }
            }

            productsTable[rows - 1, 0] = null;
            productsTable[rows - 1, 1] = null;
            productsTable[rows - 1, 2] = null;
            productsTable[rows - 1, 3] = null;
        }

        // => METÓDOS : SETTERS.

        static int SetProductCode()
        {
            int productCode = 0;

            Console.Write("Informe o código do produto: ");
            while (!int.TryParse(Console.ReadLine(), out productCode))
            {
                Console.Write("Código inválido! Informe o código do produto: ");
            }

            return productCode;
        }

        static string SetProductDescription()
        {
            string productDescription = "";

            Console.Write("Informe a descrição do produto: ");
            do
            {
                productDescription = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(productDescription))
                {
                    Console.Write("Descrição inválida! Informe a descrição do produto: ");
                }

            } while (string.IsNullOrWhiteSpace(productDescription));

            return productDescription;
        }

        static double SetProductValue()
        {
            double productValue = 0.0;

            Console.Write("Informe o preço do produto: ");
            while (!double.TryParse(Console.ReadLine(), out productValue))
            {
                Console.Write("Preço inválido! Informe o preço do produto: ");
            }

            return productValue;
        }

        static int SetProductQuantity()
        {
            int productQuantity = 0;

            Console.Write("Informe a quantidade do produto: ");
            while (!int.TryParse(Console.ReadLine(), out productQuantity))
            {
                Console.Write("Quantidade inválida! Informe a quantidade produto: ");
            }

            return productQuantity;
        }

        static int SetQuantitySold()
        {
            int quantitySold = 0;

            Console.Write("Informe a quantidade vendida: ");
            while (!int.TryParse(Console.ReadLine(), out quantitySold))
            {
                Console.Write("Quantidade inválida! Informe a quantidade vendida: ");
            }

            return quantitySold;
        }

        static int SetEmployeeCode()
        {
            int employeeCode = 0;

            Console.Write("Informe o código do funcionário: ");
            while (!int.TryParse(Console.ReadLine(), out employeeCode))
            {
                Console.Write("Código inválido! Informe o código do funcionário: ");
            }

            return employeeCode;
        }

        // => METÓDOS : GETTERS.

        static int GetProductIndex(string[,] productsTable, int productCode)
        {
            for (int i = 0; i < productsTable.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(productsTable[i, 0]) &&
                    productsTable[i, 0].Equals(productCode.ToString())
                )
                {
                    return i;
                }
            }
            return -1;
        }

        static int GetStockQuantity(string[,] productsTable, int productCode)
        {
            for (int i = 0; i < productsTable.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(productsTable[i, 0]) &&
                    productsTable[i, 0].Equals(productCode.ToString())
                )
                {
                    return Convert.ToInt32(productsTable[i, 3]);
                }
            }
            return -1;
        }

        // => MÉTODOS : VERIFICAÇÃO.

        static bool VerifyRegisterProduct(
            string[,]
            productsTable,
            int productCode,
            double productValue,
            int productQuantity
        )
        {
            if (productValue < 1)
            {
                Console.WriteLine("\nERROR: Valor minímo do produto é de R$ 1,00!");
                return false;
            }

            if (productQuantity < 1)
            {
                Console.WriteLine("\nERROR: Adicione ao menos 1 unidade no estoque!");
                return false;
            }

            if (productCode < 0)
            {
                Console.WriteLine("\nERROR: Código do produto não pode ser negativo!");
                return false;
            }

            if (GetProductIndex(productsTable, productCode) != -1)
            {
                Console.WriteLine("\nERROR: Produto com código duplicado!");
                return false;
            }

            return true;
        }

        static bool VerifyRegisterSale(
            string[,] productsTable,
            int productCode,
            int quantitySold,
            int employeeCode,
            int productIndex,
            int stockQuantity
        )
        {
            if (quantitySold < 0)
            {
                Console.WriteLine("\nERROR: Quantidade vendida não pode ser negativa!");
                return false;
            }

            if (employeeCode < 0)
            {
                Console.WriteLine("\nERROR: Código do funcionário não pode ser negativo!");
                return false;
            }

            if (productIndex == -1)
            {
                Console.WriteLine($"\nERROR: Nenhum produto em nosso estoque corresponde ao código '{productCode}'.");
                return false;
            }

            if (quantitySold > stockQuantity)
            {
                Console.WriteLine($"\nERROR: Estoque atual do produto '{productsTable[productIndex, 1]}' é de '{stockQuantity}' unidades.");
                return false;
            }

            return true;
        }

        static bool VerifyProductIndex(int productCode, int productIndex)
        {
            if (productIndex == -1)
            {
                Console.WriteLine($"\nERROR: Nenhum produto em nosso estoque corresponde ao código '{productCode}'.");
                return false;
            }

            return true;
        }
    }
}