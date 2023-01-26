using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiariesFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Clue = table.Column<string>(type: "TEXT", nullable: true),
                    Repice = table.Column<string>(type: "TEXT", nullable: false),
                    Preparation = table.Column<string>(type: "TEXT", nullable: false),
                    PreparationTime = table.Column<string>(type: "TEXT", nullable: false),
                    BakingTime = table.Column<string>(type: "TEXT", nullable: false),
                    Service = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => new { x.FoodId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FoodCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategory_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    FavoriteId = table.Column<int>(type: "INTEGER", nullable: false),
                    FavortiteNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteItems_Favorites_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteItems_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c99ed418-a56f-4b04-b29e-4a7a4fe6e556", null, "User Rolü", "User", "USER" },
                    { "feacd8f6-1bd2-4eed-babb-bca104ede603", null, "Admin Rolü", "Admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "847c7a42-4720-4ade-ac48-c455ccb61e09", 0, "85c1ff69-c3e7-4bd1-8198-f620424d4f8d", new DateTime(1980, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Sümeyye", "Kadın", "Yüce", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELTyaUTdRLPJMXHiSwsMfC3vE7xDZ3yt7+GeEmfk5Oths+KKZctx1iprYteTFoMnuw==", null, false, "49505cda-4bda-48d0-8867-14aba11845a1", false, "admin" },
                    { "e76c39fd-3963-4d01-bb75-306a486d613e", 0, "3bef7c30-be63-4453-beb3-fa160d50fb8d", new DateTime(1986, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Ornek", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAECTQo4OHa/+Im/cyHjcpPW/WS9Ag+OkKuUthTB7rQ3CW3gIe0KAz+ZFPrf1czEi6Aw==", null, false, "6aa2d2e3-eb79-4fe5-ac88-bf336fa4029b", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Et Tarifleri", "Et", "et" },
                    { 2, "Fast Food Tarifleri", "Fast Food", "fast-food" },
                    { 3, "Hamur İşi Tarifleri", "Hamur İşi", "hamur-isi" },
                    { 4, "Pilav,Makarna ve Rissotto Tarifleri", "Pilav,Makarna ve Rissotto", "pilav-makarna-rissoto" },
                    { 5, "Meze Tarifleri", "Meze", "meze" },
                    { 6, "Sos ve Krema Tarifleri", "Sos ve Krema", "sos-ve-krema" },
                    { 7, "Çorba Tarifleri", "Çorba", "corba" },
                    { 8, "içecek Tarifleri", "İçecek", "icecek" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "BakingTime", "CatId", "Clue", "ImageUrl", "IsApproved", "IsHome", "Name", "Preparation", "PreparationTime", "Repice", "Service", "Url" },
                values: new object[,]
                {
                    { 1, "60 Dk", 1, "*Kavurma Kurban Etinin Neresinden Yapılır? Kavurma, koyun ve kuzu etinin but ve kol kısmından, dana etinin ise sırt ve kol-kürek kısmından hazırlanır.\r\n*Kuyruk yağı yerine sıvı yağ kullanabilirsiniz.\r\n*Dilerseniz kavurmanızı soğanlı da yapabilirsiniz. Soğanları etleri kavurma esnasında ekleyebilirsiniz.\r\n*Dilerseniz baharat çeşitlerini ve seviyesini tadarak arttırabilirsiniz.\r\n*Mümkünse kurban etini 2-3 gün kadar +4°C’de dinlendirin.\r\n*Kurban Eti Yıkanır mı? Kurban etini hemen kullanacaksanız eğer bol suda güzelce yıkayıp süzdürmeyi ihmal etmeyin.\r\n*Tuz etin sertleşmesine sebep olduğu için tüm baharatları et piştikten sonra eklemeye özen gösterin.", "kavurma.jpeg", false, false, "Kurban Eti Kavurması", "1\r\nGeniş bir tencereye ince doğranmış kuyruk yağını ekleyip kavurmaya başlayın.\r\n2\r\nYağ erimeye başladığında kuşbaşı doğranmış kuzu etlerini tencereye ekleyin. Etler suyunu çekip salana kadar yüksek ateşte kavurmaya devam edin.\r\n3\r\nDaha sonra kısık ateşe alın. Üzeri kızarıp kahverengi bir görünüm alıncaya ve tamamen suyunu çekinceye kadar kapağı kapalı şekilde pişmeye bırakın. Pişme esnasında ara ara karıştırmayı ihmal etmeyin.\r\n4\r\nEtler yumuşayıp piştikten sonra; tuz, karabiber, kimyon, kekik, pul biber gibi dilediğiniz baharatlarla etinizi lezzetlendirip güzelce karıştırın.\r\n5\r\nOcaktan aldığınız kavurmayı, kendi tenceresinde kapağı kapalı olarak yaklaşık 10 dakika dinlendirdikten sonra sıcak olarak servis edebilirsiniz.", "2-3 Gün", "200 g kuyruk yağı\r\n1 kg kuşbaşı kuzu eti\r\nyeteri kadar tuz\r\nyeteri kadar karabiber\r\ntercihen kimyon\r\ntercihen kekik\r\ntercihen pul biber", "6-8 Kişilik", "kurban-eti-kavurmasi" },
                    { 2, "20 Dk", 1, "*Baharat oranlarını damak zevkinize göre ayarlayabilirsiniz.", "renklimakarna.jpeg", false, false, "Renkli Soğuk Makarna", "1\r\nHaşlanmış makarnayı geniş bir karıştırma kabına alın.\r\n2\r\nKıyılmış maydanozu, doğranmış avokadoyu, ikiye bölünmüş çeri domatesleri ve geri kalan tüm malzemeleri ekleyip güzelce karıştırın.\r\n3\r\nSon olarak toz baharatlarla lezzetlendirip servis edin. Afiyet olsun.", "30 Dk", "200 g haşlanmış renkli makarna\r\n1/4 demet kıyılmış maydanoz\r\n1 adet olgun avokado\r\n4-5 adet çeri domates\r\n100 g top peynir\r\n20 g konserve mısır\r\n20 g dilim zeytin\r\n10 g Hardal\r\n15 g bal\r\nkırmızı toz biber\r\ntuz\r\nkekik", "2 Kişilik", "renkli-makarna" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "feacd8f6-1bd2-4eed-babb-bca104ede603", "847c7a42-4720-4ade-ac48-c455ccb61e09" },
                    { "c99ed418-a56f-4b04-b29e-4a7a4fe6e556", "e76c39fd-3963-4d01-bb75-306a486d613e" }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "847c7a42-4720-4ade-ac48-c455ccb61e09" },
                    { 2, "e76c39fd-3963-4d01-bb75-306a486d613e" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteItems_FavoriteId",
                table: "FavoriteItems",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteItems_FoodId",
                table: "FavoriteItems",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategory_CategoryId",
                table: "FoodCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FavoriteItems");

            migrationBuilder.DropTable(
                name: "FoodCategory");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
