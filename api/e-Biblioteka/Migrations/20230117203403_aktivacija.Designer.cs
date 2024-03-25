﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_Biblioteka.Data;

namespace e_Biblioteka.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230117203403_aktivacija")]
    partial class aktivacija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("e_Biblioteka.Models.Odjeljenje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Odjeljenje");
                });

            modelBuilder.Entity("e_Biblioteka.Models.RadnoMjesto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("RadnoMjesto");
                });

            modelBuilder.Entity("e_Biblioteka.ModulAutentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IPadresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("Vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("e_Biblioteka.ModulAutentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivacija")
                        .HasColumnType("bit");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("korisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_korisnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_prethodna")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("KorisnickiNalog");

                    b.HasDiscriminator<string>("Discriminator").HasValue("KorisnickiNalog");
                });

            modelBuilder.Entity("e_Biblioteka.ModulAutentifikacija.Models.LogKretanjePoSistemu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IPadresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("exceptionMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isException")
                        .HasColumnType("bit");

                    b.Property<int>("korisnikID")
                        .HasColumnType("int");

                    b.Property<string>("postData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("queryPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijeme")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("korisnikID");

                    b.ToTable("LogKretanjePoSistemu");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.CRUDlog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<int>("KnjigaID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RadnikID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KnjigaID");

                    b.HasIndex("RadnikID");

                    b.ToTable("CRUDlog");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.IznajmljenaKnjiga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanID")
                        .HasColumnType("int");

                    b.Property<string>("ImeClana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KnjigaID")
                        .HasColumnType("int");

                    b.Property<string>("NazivKnjige")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IznajmljenaKnjiga");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.KnjigaListaZelja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImePisca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("NazivKnjige")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrezimePisca")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikID");

                    b.ToTable("KnjigaListaZelja");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.ProcitanaKnjiga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("clanID")
                        .HasColumnType("int");

                    b.Property<int>("knjigaID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clanID");

                    b.HasIndex("knjigaID");

                    b.ToTable("ProcitaneKnjige");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.RENTlog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIznajmljivanja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumVracanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("EndUserID")
                        .HasColumnType("int");

                    b.Property<int>("KnjigaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EndUserID");

                    b.HasIndex("KnjigaID");

                    b.ToTable("RENTlog");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.SHOPlog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKupovine")
                        .HasColumnType("datetime2");

                    b.Property<int>("EndUserID")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<float>("Popust")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("EndUserID");

                    b.ToTable("SHOPlog");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjige.Knjiga", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GodinaIzdavanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePisca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Izdavac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OdjeljenjeID")
                        .HasColumnType("int");

                    b.Property<string>("PrezimePisca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sekcija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stampa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("OdjeljenjeID");

                    b.ToTable("Knjiga");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Knjiga");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKorisnika.Models.Adresa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Drzava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBroj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Adresa");
                });

            modelBuilder.Entity("e_Biblioteka.ModulTrgovine.Models.CartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KnjigaID")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KnjigaID");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("e_Biblioteka.ModulTrgovine.Models.Narudzba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdresaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumDostave")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingCartID")
                        .HasColumnType("int");

                    b.Property<int>("StatusNarudzbe")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AdresaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ShoppingCartID");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("e_Biblioteka.ModulTrgovine.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartItemID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CartItemID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("e_Biblioteka.Models.Korisnik", b =>
                {
                    b.HasBaseType("e_Biblioteka.ModulAutentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("KorisnickiNalog");

                    b.HasDiscriminator().HasValue("Korisnik");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.KnjigaBiblioteka", b =>
                {
                    b.HasBaseType("e_Biblioteka.ModulKnjige.Knjiga");

                    b.ToTable("Knjiga");

                    b.HasDiscriminator().HasValue("KnjigaBiblioteka");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.KnjigaTrgovina", b =>
                {
                    b.HasBaseType("e_Biblioteka.ModulKnjige.Knjiga");

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.ToTable("Knjiga");

                    b.HasDiscriminator().HasValue("KnjigaTrgovina");
                });

            modelBuilder.Entity("e_Biblioteka.Models.EndUser", b =>
                {
                    b.HasBaseType("e_Biblioteka.Models.Korisnik");

                    b.Property<DateTime>("DatumIstekaClanarine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPlacanjaClanarine")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isClan")
                        .HasColumnType("bit");

                    b.ToTable("KorisnickiNalog");

                    b.HasDiscriminator().HasValue("EndUser");
                });

            modelBuilder.Entity("e_Biblioteka.Models.Radnik", b =>
                {
                    b.HasBaseType("e_Biblioteka.Models.Korisnik");

                    b.Property<string>("Obrazovanje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OdjeljenjeID")
                        .HasColumnType("int");

                    b.Property<int?>("PozicijaID")
                        .HasColumnType("int");

                    b.HasIndex("OdjeljenjeID");

                    b.HasIndex("PozicijaID");

                    b.ToTable("KorisnickiNalog");

                    b.HasDiscriminator().HasValue("Radnik");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKorisnika.Models.Administrator", b =>
                {
                    b.HasBaseType("e_Biblioteka.Models.Korisnik");

                    b.ToTable("KorisnickiNalog");

                    b.HasDiscriminator().HasValue("Administrator");
                });

            modelBuilder.Entity("e_Biblioteka.ModulAutentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("e_Biblioteka.ModulAutentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("e_Biblioteka.ModulAutentifikacija.Models.LogKretanjePoSistemu", b =>
                {
                    b.HasOne("e_Biblioteka.ModulAutentifikacija.Models.KorisnickiNalog", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.CRUDlog", b =>
                {
                    b.HasOne("e_Biblioteka.ModulKnjige.Knjiga", "Knjiga")
                        .WithMany()
                        .HasForeignKey("KnjigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_Biblioteka.Models.Korisnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knjiga");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.KnjigaListaZelja", b =>
                {
                    b.HasOne("e_Biblioteka.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.ProcitanaKnjiga", b =>
                {
                    b.HasOne("e_Biblioteka.Models.Korisnik", "clan")
                        .WithMany()
                        .HasForeignKey("clanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_Biblioteka.ModulKnjige.Knjiga", "knjiga")
                        .WithMany()
                        .HasForeignKey("knjigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("clan");

                    b.Navigation("knjiga");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.RENTlog", b =>
                {
                    b.HasOne("e_Biblioteka.Models.EndUser", "ClanBiblioteke")
                        .WithMany()
                        .HasForeignKey("EndUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_Biblioteka.ModulKnjiga.Models.KnjigaBiblioteka", "Knjiga")
                        .WithMany()
                        .HasForeignKey("KnjigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClanBiblioteke");

                    b.Navigation("Knjiga");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjiga.Models.SHOPlog", b =>
                {
                    b.HasOne("e_Biblioteka.Models.EndUser", "Kupac")
                        .WithMany()
                        .HasForeignKey("EndUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kupac");
                });

            modelBuilder.Entity("e_Biblioteka.ModulKnjige.Knjiga", b =>
                {
                    b.HasOne("e_Biblioteka.Models.Odjeljenje", "Odjeljenje")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeID");

                    b.Navigation("Odjeljenje");
                });

            modelBuilder.Entity("e_Biblioteka.ModulTrgovine.Models.CartItem", b =>
                {
                    b.HasOne("e_Biblioteka.ModulKnjiga.Models.KnjigaTrgovina", "Knjiga")
                        .WithMany()
                        .HasForeignKey("KnjigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knjiga");
                });

            modelBuilder.Entity("e_Biblioteka.ModulTrgovine.Models.Narudzba", b =>
                {
                    b.HasOne("e_Biblioteka.ModulKorisnika.Models.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_Biblioteka.ModulAutentifikacija.Models.KorisnickiNalog", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_Biblioteka.ModulTrgovine.Models.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartID");

                    b.Navigation("Adresa");

                    b.Navigation("Korisnik");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("e_Biblioteka.ModulTrgovine.Models.ShoppingCart", b =>
                {
                    b.HasOne("e_Biblioteka.ModulTrgovine.Models.CartItem", "CartItem")
                        .WithMany()
                        .HasForeignKey("CartItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_Biblioteka.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID");

                    b.Navigation("CartItem");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("e_Biblioteka.Models.Radnik", b =>
                {
                    b.HasOne("e_Biblioteka.Models.Odjeljenje", "Odjeljenje")
                        .WithMany()
                        .HasForeignKey("OdjeljenjeID");

                    b.HasOne("e_Biblioteka.Models.RadnoMjesto", "Pozicija")
                        .WithMany()
                        .HasForeignKey("PozicijaID");

                    b.Navigation("Odjeljenje");

                    b.Navigation("Pozicija");
                });
#pragma warning restore 612, 618
        }
    }
}
