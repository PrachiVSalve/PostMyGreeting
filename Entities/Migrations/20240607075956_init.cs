using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminTable",
                columns: table => new
                {
                    AdminId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTable", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTable",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTable", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CountryTable",
                columns: table => new
                {
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTable", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "DispatchAgencyTable",
                columns: table => new
                {
                    DispatchAgencyId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispatchAgencyTable", x => x.DispatchAgencyId);
                });

            migrationBuilder.CreateTable(
                name: "OfferTable",
                columns: table => new
                {
                    OfferId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferTable", x => x.OfferId);
                });

            migrationBuilder.CreateTable(
                name: "TaxTable",
                columns: table => new
                {
                    TaxId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HSNSACNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTable", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryTable",
                columns: table => new
                {
                    SubCategoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryTable", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategoryTable_CategoryTable_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryTable",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    StateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_State_CountryTable_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryTable",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CityTable",
                columns: table => new
                {
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTable", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_CityTable_State_StateId",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreTable",
                columns: table => new
                {
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreTable", x => x.StoreId);
                    table.ForeignKey(
                        name: "FK_StoreTable_CityTable_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTable",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderTable",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTable", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderTable_StoreTable_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreTable",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderTable_UserTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UserTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTable",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTable", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductTable_StoreTable_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreTable",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoreReviewTale",
                columns: table => new
                {
                    StoreReviewId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreReviewTale", x => x.StoreReviewId);
                    table.ForeignKey(
                        name: "FK_StoreReviewTale_StoreTable_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreTable",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StoreReviewTale_UserTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UserTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dispatch",
                columns: table => new
                {
                    DispatchId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DispatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocketNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedRichDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    DispatchAgencyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispatch", x => x.DispatchId);
                    table.ForeignKey(
                        name: "FK_Dispatch_DispatchAgencyTable_DispatchAgencyId",
                        column: x => x.DispatchAgencyId,
                        principalTable: "DispatchAgencyTable",
                        principalColumn: "DispatchAgencyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dispatch_OrderTable_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderTable",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDeliveryTable",
                columns: table => new
                {
                    OrderDeliveryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliverToPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDeliveryTable", x => x.OrderDeliveryId);
                    table.ForeignKey(
                        name: "FK_OrderDeliveryTable_CityTable_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTable",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDeliveryTable_OrderTable_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderTable",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTable",
                columns: table => new
                {
                    PaymentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMode = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTable", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_PaymentTable_OrderTable_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderTable",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartTable",
                columns: table => new
                {
                    CartId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    StoreId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartTable", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_CartTable_ProductTable_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTable",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartTable_StoreTable_StoreId",
                        column: x => x.StoreId,
                        principalTable: "StoreTable",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartTable_UserTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UserTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintTable",
                columns: table => new
                {
                    ComplaintId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompliantDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompliantResion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintTable", x => x.ComplaintId);
                    table.ForeignKey(
                        name: "FK_ComplaintTable_OrderTable_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderTable",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComplaintTable_ProductTable_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTable",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiftItem",
                columns: table => new
                {
                    GiftItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiftItemTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiftItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    SubCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftItem", x => x.GiftItemId);
                    table.ForeignKey(
                        name: "FK_GiftItem_ProductTable_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTable",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GiftItem_SubCategoryTable_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategoryTable",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GreetingCardTable ",
                columns: table => new
                {
                    GreetingCardId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDigital = table.Column<bool>(type: "bit", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GreetingCardTable ", x => x.GreetingCardId);
                    table.ForeignKey(
                        name: "FK_GreetingCardTable _ProductTable_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTable",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GreetingCardTable _SubCategoryTable_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategoryTable",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderTable_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderTable",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductTable_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTable",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReturnTable",
                columns: table => new
                {
                    ReturnId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnReasion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnTable", x => x.ReturnId);
                    table.ForeignKey(
                        name: "FK_ReturnTable_OrderTable_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderTable",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReturnTable_ProductTable_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductTable",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Solution",
                columns: table => new
                {
                    SolutionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolutionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplaintId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solution", x => x.SolutionId);
                    table.ForeignKey(
                        name: "FK_Solution_ComplaintTable_ComplaintId",
                        column: x => x.ComplaintId,
                        principalTable: "ComplaintTable",
                        principalColumn: "ComplaintId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefundTable",
                columns: table => new
                {
                    RefundId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefundDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefundAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundTable", x => x.RefundId);
                    table.ForeignKey(
                        name: "FK_RefundTable_ReturnTable_ReturnId",
                        column: x => x.ReturnId,
                        principalTable: "ReturnTable",
                        principalColumn: "ReturnId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AdminTable",
                columns: new[] { "AdminId", "Address", "EmailId", "FirstName", "LastName", "MobileNo", "Password" },
                values: new object[] { 1L, "Pune", "prachi@gmail.com", "Prachi", "Salve", "4356378965", "123" });

            migrationBuilder.CreateIndex(
                name: "IX_CartTable_ProductId",
                table: "CartTable",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartTable_StoreId",
                table: "CartTable",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CartTable_UserId",
                table: "CartTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CityTable_StateId",
                table: "CityTable",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintTable_OrderId",
                table: "ComplaintTable",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintTable_ProductId",
                table: "ComplaintTable",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispatch_DispatchAgencyId",
                table: "Dispatch",
                column: "DispatchAgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispatch_OrderId",
                table: "Dispatch",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftItem_ProductId",
                table: "GiftItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_GiftItem_SubCategoryId",
                table: "GiftItem",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GreetingCardTable _ProductId",
                table: "GreetingCardTable ",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_GreetingCardTable _SubCategoryId",
                table: "GreetingCardTable ",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDeliveryTable_CityId",
                table: "OrderDeliveryTable",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDeliveryTable_OrderId",
                table: "OrderDeliveryTable",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTable_StoreId",
                table: "OrderTable",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTable_UserId",
                table: "OrderTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTable_OrderId",
                table: "PaymentTable",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTable_StoreId",
                table: "ProductTable",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_RefundTable_ReturnId",
                table: "RefundTable",
                column: "ReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnTable_OrderId",
                table: "ReturnTable",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnTable_ProductId",
                table: "ReturnTable",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Solution_ComplaintId",
                table: "Solution",
                column: "ComplaintId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreReviewTale_StoreId",
                table: "StoreReviewTale",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreReviewTale_UserId",
                table: "StoreReviewTale",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreTable_CityId",
                table: "StoreTable",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryTable_CategoryID",
                table: "SubCategoryTable",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTable");

            migrationBuilder.DropTable(
                name: "CartTable");

            migrationBuilder.DropTable(
                name: "Dispatch");

            migrationBuilder.DropTable(
                name: "GiftItem");

            migrationBuilder.DropTable(
                name: "GreetingCardTable ");

            migrationBuilder.DropTable(
                name: "OfferTable");

            migrationBuilder.DropTable(
                name: "OrderDeliveryTable");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PaymentTable");

            migrationBuilder.DropTable(
                name: "RefundTable");

            migrationBuilder.DropTable(
                name: "Solution");

            migrationBuilder.DropTable(
                name: "StoreReviewTale");

            migrationBuilder.DropTable(
                name: "TaxTable");

            migrationBuilder.DropTable(
                name: "DispatchAgencyTable");

            migrationBuilder.DropTable(
                name: "SubCategoryTable");

            migrationBuilder.DropTable(
                name: "ReturnTable");

            migrationBuilder.DropTable(
                name: "ComplaintTable");

            migrationBuilder.DropTable(
                name: "CategoryTable");

            migrationBuilder.DropTable(
                name: "OrderTable");

            migrationBuilder.DropTable(
                name: "ProductTable");

            migrationBuilder.DropTable(
                name: "UserTable");

            migrationBuilder.DropTable(
                name: "StoreTable");

            migrationBuilder.DropTable(
                name: "CityTable");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "CountryTable");
        }
    }
}
