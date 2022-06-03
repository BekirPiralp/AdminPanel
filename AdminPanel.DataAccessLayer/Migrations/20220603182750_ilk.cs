using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminPanel.DataAccessLayer.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArabaBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ArabaKasaTipleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaKasaTipleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ArabaMarkalari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMarkalari", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ArabaTipleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaTipleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ArabaVitesTipleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaVitesTipleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GaleriBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaleriBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HakkindaBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HakkindaBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HakkindaIcerikleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resimURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HakkindaIcerikleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HakkindaReklamlar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HakkindaReklamlar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HizmetBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hizmetler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resimURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hizmetler", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IletisimBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Iletisimleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisimleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IpucuVeYaziBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpucuVeYaziBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "IpucuVeYazilar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpucuVeYazilar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    konu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PaketBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Paketler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fiyat = table.Column<double>(type: "float", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paketler", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PaketOzellikleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketOzellikleri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelBolumBilgileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    altBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelBolumBilgileri", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalMedyaLogolari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalMedyaLogolari", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipid = table.Column<int>(type: "int", nullable: false),
                    markaid = table.Column<int>(type: "int", nullable: false),
                    kasaTipid = table.Column<int>(type: "int", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resimURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uretimYili = table.Column<int>(type: "int", nullable: false),
                    vitesTipid = table.Column<int>(type: "int", nullable: false),
                    gunlukFiyat = table.Column<double>(type: "float", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.id);
                    table.ForeignKey(
                        name: "FK_Arabalar_ArabaKasaTipleri_kasaTipid",
                        column: x => x.kasaTipid,
                        principalTable: "ArabaKasaTipleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arabalar_ArabaMarkalari_markaid",
                        column: x => x.markaid,
                        principalTable: "ArabaMarkalari",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arabalar_ArabaTipleri_tipid",
                        column: x => x.tipid,
                        principalTable: "ArabaTipleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arabalar_ArabaVitesTipleri_vitesTipid",
                        column: x => x.vitesTipid,
                        principalTable: "ArabaVitesTipleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HizmetAltlar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hizmetid = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetAltlar", x => x.id);
                    table.ForeignKey(
                        name: "FK_HizmetAltlar_Hizmetler_hizmetid",
                        column: x => x.hizmetid,
                        principalTable: "Hizmetler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    logoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iletisimid = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.id);
                    table.ForeignKey(
                        name: "FK_Firmalar_Iletisimleri_iletisimid",
                        column: x => x.iletisimid,
                        principalTable: "Iletisimleri",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "PaketAitOzellikleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paketid = table.Column<int>(type: "int", nullable: false),
                    ozellikid = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketAitOzellikleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_PaketAitOzellikleri_Paketler_paketid",
                        column: x => x.paketid,
                        principalTable: "Paketler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaketAitOzellikleri_PaketOzellikleri_ozellikid",
                        column: x => x.ozellikid,
                        principalTable: "PaketOzellikleri",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelGorevleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personelid = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelGorevleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonelGorevleri_Personeller_personelid",
                        column: x => x.personelid,
                        principalTable: "Personeller",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelSifreleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personelid = table.Column<int>(type: "int", nullable: false),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelSifreleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonelSifreleri_Personeller_personelid",
                        column: x => x.personelid,
                        principalTable: "Personeller",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelSosyalMedyalari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personelid = table.Column<int>(type: "int", nullable: false),
                    sosyalMedyaURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sosyalMedyaLogoid = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelSosyalMedyalari", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonelSosyalMedyalari_Personeller_personelid",
                        column: x => x.personelid,
                        principalTable: "Personeller",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelSosyalMedyalari_SosyalMedyaLogolari_sosyalMedyaLogoid",
                        column: x => x.sosyalMedyaLogoid,
                        principalTable: "SosyalMedyaLogolari",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArabaOzellikleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arabaid = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaOzellikleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_ArabaOzellikleri_Arabalar_arabaid",
                        column: x => x.arabaid,
                        principalTable: "Arabalar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HizmetAltOzellikler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hizmetAltid = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizmetAltOzellikler", x => x.id);
                    table.ForeignKey(
                        name: "FK_HizmetAltOzellikler_HizmetAltlar_hizmetAltid",
                        column: x => x.hizmetAltid,
                        principalTable: "HizmetAltlar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bayiler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmaid = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iletisimid = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bayiler", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bayiler_Firmalar_firmaid",
                        column: x => x.firmaid,
                        principalTable: "Firmalar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bayiler_Iletisimleri_iletisimid",
                        column: x => x.iletisimid,
                        principalTable: "Iletisimleri",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "FirmaSahipleri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmaid = table.Column<int>(type: "int", nullable: false),
                    personelid = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaSahipleri", x => x.id);
                    table.ForeignKey(
                        name: "FK_FirmaSahipleri_Firmalar_firmaid",
                        column: x => x.firmaid,
                        principalTable: "Firmalar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirmaSahipleri_Personeller_personelid",
                        column: x => x.personelid,
                        principalTable: "Personeller",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmaid = table.Column<int>(type: "int", nullable: false),
                    tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.id);
                    table.ForeignKey(
                        name: "FK_Musteriler_Firmalar_firmaid",
                        column: x => x.firmaid,
                        principalTable: "Firmalar",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BayiYoneticileri",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmaid = table.Column<int>(type: "int", nullable: false),
                    bayiid = table.Column<int>(type: "int", nullable: false),
                    personelid = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<bool>(type: "bit", nullable: false),
                    kayitZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    silmeZamani = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guncellemeZamani = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BayiYoneticileri", x => x.id);
                    table.ForeignKey(
                        name: "FK_BayiYoneticileri_Bayiler_bayiid",
                        column: x => x.bayiid,
                        principalTable: "Bayiler",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BayiYoneticileri_Firmalar_firmaid",
                        column: x => x.firmaid,
                        principalTable: "Firmalar",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_BayiYoneticileri_Personeller_personelid",
                        column: x => x.personelid,
                        principalTable: "Personeller",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_kasaTipid",
                table: "Arabalar",
                column: "kasaTipid");

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_markaid",
                table: "Arabalar",
                column: "markaid");

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_tipid",
                table: "Arabalar",
                column: "tipid");

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_vitesTipid",
                table: "Arabalar",
                column: "vitesTipid");

            migrationBuilder.CreateIndex(
                name: "IX_ArabaOzellikleri_arabaid",
                table: "ArabaOzellikleri",
                column: "arabaid");

            migrationBuilder.CreateIndex(
                name: "IX_Bayiler_firmaid",
                table: "Bayiler",
                column: "firmaid");

            migrationBuilder.CreateIndex(
                name: "IX_Bayiler_iletisimid",
                table: "Bayiler",
                column: "iletisimid");

            migrationBuilder.CreateIndex(
                name: "IX_BayiYoneticileri_bayiid",
                table: "BayiYoneticileri",
                column: "bayiid");

            migrationBuilder.CreateIndex(
                name: "IX_BayiYoneticileri_firmaid",
                table: "BayiYoneticileri",
                column: "firmaid");

            migrationBuilder.CreateIndex(
                name: "IX_BayiYoneticileri_personelid",
                table: "BayiYoneticileri",
                column: "personelid");

            migrationBuilder.CreateIndex(
                name: "IX_Firmalar_iletisimid",
                table: "Firmalar",
                column: "iletisimid");

            migrationBuilder.CreateIndex(
                name: "IX_FirmaSahipleri_firmaid",
                table: "FirmaSahipleri",
                column: "firmaid");

            migrationBuilder.CreateIndex(
                name: "IX_FirmaSahipleri_personelid",
                table: "FirmaSahipleri",
                column: "personelid");

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltlar_hizmetid",
                table: "HizmetAltlar",
                column: "hizmetid");

            migrationBuilder.CreateIndex(
                name: "IX_HizmetAltOzellikler_hizmetAltid",
                table: "HizmetAltOzellikler",
                column: "hizmetAltid");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_firmaid",
                table: "Musteriler",
                column: "firmaid");

            migrationBuilder.CreateIndex(
                name: "IX_PaketAitOzellikleri_ozellikid",
                table: "PaketAitOzellikleri",
                column: "ozellikid");

            migrationBuilder.CreateIndex(
                name: "IX_PaketAitOzellikleri_paketid",
                table: "PaketAitOzellikleri",
                column: "paketid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelGorevleri_personelid",
                table: "PersonelGorevleri",
                column: "personelid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelSifreleri_personelid",
                table: "PersonelSifreleri",
                column: "personelid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelSosyalMedyalari_personelid",
                table: "PersonelSosyalMedyalari",
                column: "personelid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelSosyalMedyalari_sosyalMedyaLogoid",
                table: "PersonelSosyalMedyalari",
                column: "sosyalMedyaLogoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArabaBolumBilgileri");

            migrationBuilder.DropTable(
                name: "ArabaOzellikleri");

            migrationBuilder.DropTable(
                name: "BayiYoneticileri");

            migrationBuilder.DropTable(
                name: "FirmaSahipleri");

            migrationBuilder.DropTable(
                name: "GaleriBolumBilgileri");

            migrationBuilder.DropTable(
                name: "HakkindaBolumBilgileri");

            migrationBuilder.DropTable(
                name: "HakkindaIcerikleri");

            migrationBuilder.DropTable(
                name: "HakkindaReklamlar");

            migrationBuilder.DropTable(
                name: "HizmetAltOzellikler");

            migrationBuilder.DropTable(
                name: "HizmetBolumBilgileri");

            migrationBuilder.DropTable(
                name: "IletisimBolumBilgileri");

            migrationBuilder.DropTable(
                name: "IpucuVeYaziBolumBilgileri");

            migrationBuilder.DropTable(
                name: "IpucuVeYazilar");

            migrationBuilder.DropTable(
                name: "Mesajlar");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "PaketAitOzellikleri");

            migrationBuilder.DropTable(
                name: "PaketBolumBilgileri");

            migrationBuilder.DropTable(
                name: "PersonelBolumBilgileri");

            migrationBuilder.DropTable(
                name: "PersonelGorevleri");

            migrationBuilder.DropTable(
                name: "PersonelSifreleri");

            migrationBuilder.DropTable(
                name: "PersonelSosyalMedyalari");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Bayiler");

            migrationBuilder.DropTable(
                name: "HizmetAltlar");

            migrationBuilder.DropTable(
                name: "Paketler");

            migrationBuilder.DropTable(
                name: "PaketOzellikleri");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "SosyalMedyaLogolari");

            migrationBuilder.DropTable(
                name: "ArabaKasaTipleri");

            migrationBuilder.DropTable(
                name: "ArabaMarkalari");

            migrationBuilder.DropTable(
                name: "ArabaTipleri");

            migrationBuilder.DropTable(
                name: "ArabaVitesTipleri");

            migrationBuilder.DropTable(
                name: "Firmalar");

            migrationBuilder.DropTable(
                name: "Hizmetler");

            migrationBuilder.DropTable(
                name: "Iletisimleri");
        }
    }
}
