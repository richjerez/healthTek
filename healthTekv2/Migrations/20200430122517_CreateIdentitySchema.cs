using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace healthTekv2.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    clients_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    client_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    client_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.clients_id);
                });

            migrationBuilder.CreateTable(
                name: "contractors",
                columns: table => new
                {
                    contractors_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    contractor_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    contractor_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    contractor_type = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    pay_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    is_active = table.Column<ulong>(type: "bit(1)", nullable: true),
                    hr_ready = table.Column<ulong>(type: "bit(1)", nullable: true),
                    area_of_responsibility = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contractors", x => x.contractors_id);
                });

            migrationBuilder.CreateTable(
                name: "diagnoses",
                columns: table => new
                {
                    diagnoses_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    diagnosis_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    diagnosis_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnoses", x => x.diagnoses_id);
                });

            migrationBuilder.CreateTable(
                name: "facilities",
                columns: table => new
                {
                    facilities_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    facility_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    facility_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    date_of_arrival = table.Column<DateTime>(type: "date", nullable: true),
                    medical_record_number = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    referred_by = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    referred_identifier = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    supervisor = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facilities", x => x.facilities_id);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    persons_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    person_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    person_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    first_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    last_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    middle_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    social_sec_number = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    gender = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    date_of_birth = table.Column<DateTime>(type: "date", nullable: true),
                    age = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    religion = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    language = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    ethnicity = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    email = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.persons_id);
                });

            migrationBuilder.CreateTable(
                name: "policies",
                columns: table => new
                {
                    policies_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    policy_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    policy_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    policy_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    policy_number = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    policy_eff_date = table.Column<DateTime>(type: "date", nullable: true),
                    policy_exp_date = table.Column<DateTime>(type: "date", nullable: true),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_policies", x => x.policies_id);
                    table.ForeignKey(
                        name: "fk_policies_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "prescriptions",
                columns: table => new
                {
                    prescriptions_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    prescription_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    prescription_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    prescription_identifier = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    prescription_frequency = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    prescription_duration = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    prescription_dosage = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prescriptions", x => x.prescriptions_id);
                    table.ForeignKey(
                        name: "fk_prescriptions_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "papers",
                columns: table => new
                {
                    papers_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    paper_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    paper_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    paper_title = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    paper_status = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    paper_eff_date = table.Column<DateTime>(type: "date", nullable: true),
                    paper_exp_date = table.Column<DateTime>(type: "date", nullable: true),
                    paper_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    paper_identifier = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    required_item = table.Column<ulong>(type: "bit(1)", nullable: true),
                    exp_warning_num_days = table.Column<short>(type: "smallint(6)", nullable: true),
                    digital_paper = table.Column<byte[]>(nullable: false),
                    is_sorted = table.Column<ulong>(type: "bit(1)", nullable: true),
                    upload_date = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_contractors_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_papers", x => x.papers_id);
                    table.ForeignKey(
                        name: "fk_papers_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_papers_contractors",
                        column: x => x.fk_contractors_id,
                        principalTable: "contractors",
                        principalColumn: "contractors_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "providers",
                columns: table => new
                {
                    providers_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    provider_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    provider_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    provider_company = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    provider_number = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    provider_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    provider_url = table.Column<string>(type: "varchar(2083)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    provider_ein = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    provider_identifier = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_contractors_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_providers", x => x.providers_id);
                    table.ForeignKey(
                        name: "fk_providers_contractors",
                        column: x => x.fk_contractors_id,
                        principalTable: "contractors",
                        principalColumn: "contractors_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "assignments",
                columns: table => new
                {
                    assignments_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    assignment_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    assignment_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    assignment_position = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    assignment_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    assignment_counter = table.Column<short>(type: "smallint(6)", nullable: true),
                    assignment_eff_date = table.Column<DateTime>(type: "date", nullable: true),
                    assignment_exp_date = table.Column<DateTime>(type: "date", nullable: true),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_contractors_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_facilities_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assignments", x => x.assignments_id);
                    table.ForeignKey(
                        name: "fk_assignments_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_assignments_contractors",
                        column: x => x.fk_contractors_id,
                        principalTable: "contractors",
                        principalColumn: "contractors_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_assignments_facilities",
                        column: x => x.fk_facilities_id,
                        principalTable: "facilities",
                        principalColumn: "facilities_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    invoices_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    invoice_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    invoice_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    invoice_status = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    invoice = table.Column<byte[]>(nullable: true),
                    invoice_amount = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    fk_facilities_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.invoices_id);
                    table.ForeignKey(
                        name: "fk_invoices_facilities",
                        column: x => x.fk_facilities_id,
                        principalTable: "facilities",
                        principalColumn: "facilities_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    addresses_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    address_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    address_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    address1 = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    address2 = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    city = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    state = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    zip = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    region = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    country = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    gps_coordinates = table.Column<decimal>(type: "decimal(10,8)", nullable: true),
                    fk_persons_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_facilities_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.addresses_id);
                    table.ForeignKey(
                        name: "fk_addresses_facilities",
                        column: x => x.fk_facilities_id,
                        principalTable: "facilities",
                        principalColumn: "facilities_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_addresses_persons",
                        column: x => x.fk_persons_id,
                        principalTable: "persons",
                        principalColumn: "persons_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "contractors_clients",
                columns: table => new
                {
                    clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    contractors_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_persons_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_facilities_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.clients_id, x.contractors_id });
                    table.ForeignKey(
                        name: "fk_contractors_clients_facilities",
                        column: x => x.fk_facilities_id,
                        principalTable: "facilities",
                        principalColumn: "facilities_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_contractors_clients_persons",
                        column: x => x.fk_persons_id,
                        principalTable: "persons",
                        principalColumn: "persons_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "e_signs",
                columns: table => new
                {
                    e_signs_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    e_signs_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    e_signs_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    e_sign_consent = table.Column<ulong>(type: "bit(1)", nullable: true),
                    e_sign_ip = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    e_signature = table.Column<byte[]>(nullable: true),
                    fk_persons_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_e_signs", x => x.e_signs_id);
                    table.ForeignKey(
                        name: "fk_e_signs_persons",
                        column: x => x.fk_persons_id,
                        principalTable: "persons",
                        principalColumn: "persons_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "phone_numbers",
                columns: table => new
                {
                    phone_numbers_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    phone_number_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    phone_number_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    phone_type = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    phone_number = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_persons_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phone_numbers", x => x.phone_numbers_id);
                    table.ForeignKey(
                        name: "fk_phone_numbers_persons",
                        column: x => x.fk_persons_id,
                        principalTable: "persons",
                        principalColumn: "persons_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "relationships",
                columns: table => new
                {
                    relationships_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    relationship_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    relationship_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    relationship_type = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_persons_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relationships", x => x.relationships_id);
                    table.ForeignKey(
                        name: "fk_relationships_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_relationships_persons",
                        column: x => x.fk_persons_id,
                        principalTable: "persons",
                        principalColumn: "persons_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "authorizations",
                columns: table => new
                {
                    authorizations_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    authorization_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    authorization_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    authorization_code = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    authorization_eff_date = table.Column<DateTime>(type: "date", nullable: false),
                    authorization_exp_date = table.Column<DateTime>(type: "date", nullable: false),
                    authorization_number = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    authorization_status = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    authorization_type = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    unit_amount = table.Column<int>(type: "int(11)", nullable: true),
                    units_used = table.Column<int>(type: "int(11)", nullable: true),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_facilities_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_policies_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorizations", x => x.authorizations_id);
                    table.ForeignKey(
                        name: "fk_authorizations_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_authorizations_facilities",
                        column: x => x.fk_facilities_id,
                        principalTable: "facilities",
                        principalColumn: "facilities_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_authorizations_policies",
                        column: x => x.fk_policies_id,
                        principalTable: "policies",
                        principalColumn: "policies_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "medications",
                columns: table => new
                {
                    medications_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    medication_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    medication_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    medication_type = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    medication_name = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    medication_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_prescriptions_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medications", x => x.medications_id);
                    table.ForeignKey(
                        name: "fk_medications_prescriptions",
                        column: x => x.fk_prescriptions_id,
                        principalTable: "prescriptions",
                        principalColumn: "prescriptions_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "claims",
                columns: table => new
                {
                    claims_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    claim_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    claim_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    claim_status = table.Column<string>(type: "varchar(75)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    check_number = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    dispute_reason = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    paid_by_insurancedate = table.Column<DateTime>(name: "paid_by_insurance date", type: "date", nullable: true),
                    reconciled_date = table.Column<DateTime>(type: "date", nullable: true),
                    paid_to_contractor_date = table.Column<DateTime>(type: "date", nullable: true),
                    fk_invoices_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claims", x => x.claims_id);
                    table.ForeignKey(
                        name: "fk_claims_invoices",
                        column: x => x.fk_invoices_id,
                        principalTable: "invoices",
                        principalColumn: "invoices_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "procedures",
                columns: table => new
                {
                    procedures_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    procedure_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    procedure_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    client_daily_limit = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    contractor_daily_limit = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    procedure_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    procedure_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    premium_amount = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    procedure_units = table.Column<short>(type: "smallint(6)", nullable: true),
                    fk_authorizations_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_claims_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procedures", x => x.procedures_id);
                    table.ForeignKey(
                        name: "fk_procedures_authorizations",
                        column: x => x.fk_authorizations_id,
                        principalTable: "authorizations",
                        principalColumn: "authorizations_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_procedures_claims",
                        column: x => x.fk_claims_id,
                        principalTable: "claims",
                        principalColumn: "claims_id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "replacing entity services");

            migrationBuilder.CreateTable(
                name: "codes",
                columns: table => new
                {
                    codes_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    code_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    code_type = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    code_title = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    code_eff_date = table.Column<DateTime>(type: "date", nullable: true),
                    code_exp_date = table.Column<DateTime>(type: "date", nullable: true),
                    code_description = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    code_rate_type = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    code_rate = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    fk_procedures_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_codes", x => x.codes_id);
                    table.ForeignKey(
                        name: "fk_codes_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_codes_procedures",
                        column: x => x.fk_procedures_id,
                        principalTable: "procedures",
                        principalColumn: "procedures_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    locations_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    location_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    location_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    location_type = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    location_name = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    location_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_procedures_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.locations_id);
                    table.ForeignKey(
                        name: "fk_locations_procedures",
                        column: x => x.fk_procedures_id,
                        principalTable: "procedures",
                        principalColumn: "procedures_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "goals",
                columns: table => new
                {
                    goals_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    goal_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    goal_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    goal_type = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    goal_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    goal_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    goal_status = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_behaviors_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_programs_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goals", x => x.goals_id);
                    table.ForeignKey(
                        name: "fk_goals_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "objectives",
                columns: table => new
                {
                    objectives_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    objective_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    objective_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    objective_type = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    objective_status = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    objective_number = table.Column<string>(type: "varchar(45)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    objective_title = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    objective_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_goals_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objectives", x => x.objectives_id);
                    table.ForeignKey(
                        name: "fk_objectives_goals",
                        column: x => x.fk_goals_id,
                        principalTable: "goals",
                        principalColumn: "goals_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "programs",
                columns: table => new
                {
                    programs_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    program_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    program_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    program_name = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    program_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    program_eff_date = table.Column<DateTime>(type: "date", nullable: true),
                    program_exp_date = table.Column<DateTime>(type: "date", nullable: true),
                    fk_behaviors_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_goals_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_remedies_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_programs", x => x.programs_id);
                    table.ForeignKey(
                        name: "fk_programs_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_programs_goals",
                        column: x => x.fk_goals_id,
                        principalTable: "goals",
                        principalColumn: "goals_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "behaviors",
                columns: table => new
                {
                    behaviors_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    behavior_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    behavior_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    behavior_name = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    behavior_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    behavior_date = table.Column<DateTime>(type: "date", nullable: true),
                    sto_num_months = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    baseline = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_programs_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_behaviors", x => x.behaviors_id);
                    table.ForeignKey(
                        name: "fk_behaviors_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_behaviors_programs",
                        column: x => x.fk_programs_id,
                        principalTable: "programs",
                        principalColumn: "programs_id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "maladaptive or replacement behaviors");

            migrationBuilder.CreateTable(
                name: "intakes",
                columns: table => new
                {
                    intakes_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    intake_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    intake_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    intake_status = table.Column<string>(type: "varchar(75)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    intake_eff_date = table.Column<DateTime>(type: "date", nullable: true),
                    intake_exp_date = table.Column<DateTime>(type: "date", nullable: true),
                    fk_facilities_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_programs_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intakes", x => x.intakes_id);
                    table.ForeignKey(
                        name: "fk_intakes_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_intakes_facilities",
                        column: x => x.fk_facilities_id,
                        principalTable: "facilities",
                        principalColumn: "facilities_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_intakes_programs",
                        column: x => x.fk_programs_id,
                        principalTable: "programs",
                        principalColumn: "programs_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "remedies",
                columns: table => new
                {
                    remedies_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    remedy_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    remedy_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    remedy_name = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    remedy_description = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_programs_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_remedies", x => x.remedies_id);
                    table.ForeignKey(
                        name: "fk_remedies_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_remedies_programs",
                        column: x => x.fk_programs_id,
                        principalTable: "programs",
                        principalColumn: "programs_id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "replacing interventions and reinforcers tables");

            migrationBuilder.CreateTable(
                name: "trials",
                columns: table => new
                {
                    trials_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    trial_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    trial_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    successful_trials = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    total_trials = table.Column<sbyte>(type: "tinyint(4)", nullable: true),
                    fk_behaviors_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trials", x => x.trials_id);
                    table.ForeignKey(
                        name: "fk_trials_behaviors",
                        column: x => x.fk_behaviors_id,
                        principalTable: "behaviors",
                        principalColumn: "behaviors_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    appointments_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    appointment_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    appointment_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    appointment_date = table.Column<DateTime>(type: "date", nullable: false),
                    appointment_status = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    appointment_start_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    appointment_end_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    appointment_attachment = table.Column<byte[]>(nullable: true),
                    fk_clients_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_contractors_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_comments_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_facilities_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_locations_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_procedures_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_supervisions_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_users_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.appointments_id);
                    table.ForeignKey(
                        name: "fk_appointments_clients",
                        column: x => x.fk_clients_id,
                        principalTable: "clients",
                        principalColumn: "clients_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_appointments_contractors",
                        column: x => x.fk_contractors_id,
                        principalTable: "contractors",
                        principalColumn: "contractors_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_appointments_facilities",
                        column: x => x.fk_facilities_id,
                        principalTable: "facilities",
                        principalColumn: "facilities_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_appointments_locations",
                        column: x => x.fk_locations_id,
                        principalTable: "locations",
                        principalColumn: "locations_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_appointments_procedures",
                        column: x => x.fk_procedures_id,
                        principalTable: "procedures",
                        principalColumn: "procedures_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "supervisions",
                columns: table => new
                {
                    supervisions_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supervision_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    supervision_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    supervision_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    supervision_date = table.Column<DateTime>(type: "date", nullable: true),
                    supervision_mode = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    client_present = table.Column<ulong>(type: "bit(1)", nullable: true),
                    supervision_characteristic = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_comments_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_providers_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supervisions", x => x.supervisions_id);
                    table.ForeignKey(
                        name: "fk_supervisions_providers",
                        column: x => x.fk_providers_id,
                        principalTable: "providers",
                        principalColumn: "providers_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tasks",
                columns: table => new
                {
                    tasks_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    task_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    task_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    scheduled_by = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    task_type = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    task_status = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    task_regarding = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    due_date = table.Column<DateTime>(type: "date", nullable: true),
                    task_attachment = table.Column<byte[]>(nullable: true),
                    is_cleared = table.Column<ulong>(type: "bit(1)", nullable: true),
                    fk_comments_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_users_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tasks", x => x.tasks_id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    users_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    user_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    username = table.Column<string>(type: "varchar(75)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    password = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    password_confirm = table.Column<string>(type: "varchar(45)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_contractors_id = table.Column<int>(type: "int(11)", nullable: false),
                    fk_comments_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.users_id);
                    table.ForeignKey(
                        name: "fk_users_contractors",
                        column: x => x.fk_contractors_id,
                        principalTable: "contractors",
                        principalColumn: "contractors_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    comments_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    comment_created_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    comment_modified_ts = table.Column<DateTime>(type: "timestamp", nullable: false),
                    comment_title = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    comment_sender = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    comment_message = table.Column<string>(type: "varchar(500)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_0900_ai_ci"),
                    fk_users_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.comments_id);
                    table.ForeignKey(
                        name: "fk_comments_users",
                        column: x => x.fk_users_id,
                        principalTable: "users",
                        principalColumn: "users_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "idx_city",
                table: "addresses",
                column: "city");

            migrationBuilder.CreateIndex(
                name: "fk_addresses_facilities_idx",
                table: "addresses",
                column: "fk_facilities_id");

            migrationBuilder.CreateIndex(
                name: "fk_addresses_persons_idx",
                table: "addresses",
                column: "fk_persons_id");

            migrationBuilder.CreateIndex(
                name: "idx_state",
                table: "addresses",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "idx_country",
                table: "addresses",
                columns: new[] { "country", "region" });

            migrationBuilder.CreateIndex(
                name: "idx_address",
                table: "addresses",
                columns: new[] { "address1", "address2", "region" });

            migrationBuilder.CreateIndex(
                name: "idx_appointment_status",
                table: "appointments",
                column: "appointment_status");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_clients_idx",
                table: "appointments",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_comments_idx",
                table: "appointments",
                column: "fk_comments_id");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_contractors_idx",
                table: "appointments",
                column: "fk_contractors_id");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_facilities_idx",
                table: "appointments",
                column: "fk_facilities_id");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_locations_idx",
                table: "appointments",
                column: "fk_locations_id");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_procedures_idx",
                table: "appointments",
                column: "fk_procedures_id");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_supervisions_idx",
                table: "appointments",
                column: "fk_supervisions_id");

            migrationBuilder.CreateIndex(
                name: "fk_appointments_users_idx",
                table: "appointments",
                column: "fk_users_id");

            migrationBuilder.CreateIndex(
                name: "idx_assignment_position",
                table: "assignments",
                column: "assignment_position");

            migrationBuilder.CreateIndex(
                name: "idx_assignment_status",
                table: "assignments",
                column: "assignment_status");

            migrationBuilder.CreateIndex(
                name: "fk_assignments_clients_idx",
                table: "assignments",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_assignments_contractors_idx",
                table: "assignments",
                column: "fk_contractors_id");

            migrationBuilder.CreateIndex(
                name: "fk_assignments_facilities_idx",
                table: "assignments",
                column: "fk_facilities_id");

            migrationBuilder.CreateIndex(
                name: "idx_authorization_code",
                table: "authorizations",
                column: "authorization_code");

            migrationBuilder.CreateIndex(
                name: "idx_authorization_number",
                table: "authorizations",
                column: "authorization_number");

            migrationBuilder.CreateIndex(
                name: "idx_authorization_status",
                table: "authorizations",
                column: "authorization_status");

            migrationBuilder.CreateIndex(
                name: "idx_authorization_type",
                table: "authorizations",
                column: "authorization_type");

            migrationBuilder.CreateIndex(
                name: "fk_authorizations_clients_idx",
                table: "authorizations",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_authorizations_facilities_idx",
                table: "authorizations",
                column: "fk_facilities_id");

            migrationBuilder.CreateIndex(
                name: "fk_authorizations_policies_idx",
                table: "authorizations",
                column: "fk_policies_id");

            migrationBuilder.CreateIndex(
                name: "fk_behaviors_clients_idx",
                table: "behaviors",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_behaviors_programs_idx",
                table: "behaviors",
                column: "fk_programs_id");

            migrationBuilder.CreateIndex(
                name: "idx_behavior_description",
                table: "behaviors",
                columns: new[] { "behavior_description", "behavior_name" });

            migrationBuilder.CreateIndex(
                name: "idx_behavior_name",
                table: "behaviors",
                columns: new[] { "behavior_name", "behavior_description" });

            migrationBuilder.CreateIndex(
                name: "idx_check_number",
                table: "claims",
                column: "check_number");

            migrationBuilder.CreateIndex(
                name: "idx_claim_status",
                table: "claims",
                column: "claim_status");

            migrationBuilder.CreateIndex(
                name: "idx_dispute_reason",
                table: "claims",
                column: "dispute_reason");

            migrationBuilder.CreateIndex(
                name: "fk_claims_invoices_idx",
                table: "claims",
                column: "fk_invoices_id");

            migrationBuilder.CreateIndex(
                name: "idx_code_type",
                table: "codes",
                column: "code_type");

            migrationBuilder.CreateIndex(
                name: "fk_codes_clients_idx",
                table: "codes",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_codes_procedures_idx",
                table: "codes",
                column: "fk_procedures_id");

            migrationBuilder.CreateIndex(
                name: "idx_code_title",
                table: "codes",
                columns: new[] { "code_title", "code_description" });

            migrationBuilder.CreateIndex(
                name: "idx_code_description",
                table: "codes",
                columns: new[] { "code_description", "code_title", "code_type" });

            migrationBuilder.CreateIndex(
                name: "idx_comment_sender",
                table: "comments",
                column: "comment_sender");

            migrationBuilder.CreateIndex(
                name: "idx_comment_title",
                table: "comments",
                column: "comment_title");

            migrationBuilder.CreateIndex(
                name: "fk_comments_users_idx",
                table: "comments",
                column: "fk_users_id");

            migrationBuilder.CreateIndex(
                name: "idx_comment_message",
                table: "comments",
                columns: new[] { "comment_message", "comment_title" });

            migrationBuilder.CreateIndex(
                name: "idx_area_of_responsibility",
                table: "contractors",
                column: "area_of_responsibility");

            migrationBuilder.CreateIndex(
                name: "idx_contractor_type",
                table: "contractors",
                column: "contractor_type");

            migrationBuilder.CreateIndex(
                name: "fk_contractors_clients_facilities_idx",
                table: "contractors_clients",
                column: "fk_facilities_id");

            migrationBuilder.CreateIndex(
                name: "fk_contractors_clients_persons_idx",
                table: "contractors_clients",
                column: "fk_persons_id");

            migrationBuilder.CreateIndex(
                name: "idx_e_sign_ip",
                table: "e_signs",
                column: "e_sign_ip");

            migrationBuilder.CreateIndex(
                name: "fk_e_signs_persons_idx",
                table: "e_signs",
                column: "fk_persons_id");

            migrationBuilder.CreateIndex(
                name: "idx_medical_record_number",
                table: "facilities",
                column: "medical_record_number");

            migrationBuilder.CreateIndex(
                name: "idx_supervisor",
                table: "facilities",
                column: "supervisor");

            migrationBuilder.CreateIndex(
                name: "idx_referred_by",
                table: "facilities",
                columns: new[] { "referred_by", "referred_identifier" });

            migrationBuilder.CreateIndex(
                name: "fk_goals_behaviors_idx",
                table: "goals",
                column: "fk_behaviors_id");

            migrationBuilder.CreateIndex(
                name: "fk_goals_clients_idx",
                table: "goals",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_goals_programs_idx",
                table: "goals",
                column: "fk_programs_id");

            migrationBuilder.CreateIndex(
                name: "idx_goal_name",
                table: "goals",
                column: "goal_name");

            migrationBuilder.CreateIndex(
                name: "idx_goal_status",
                table: "goals",
                column: "goal_status");

            migrationBuilder.CreateIndex(
                name: "idx_goal_type",
                table: "goals",
                column: "goal_type");

            migrationBuilder.CreateIndex(
                name: "idx_goal_description",
                table: "goals",
                columns: new[] { "goal_description", "goal_name", "goal_type" });

            migrationBuilder.CreateIndex(
                name: "fk_intakes_clients",
                table: "intakes",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_intakes_facilities",
                table: "intakes",
                column: "fk_facilities_id");

            migrationBuilder.CreateIndex(
                name: "fk_intakes_programs",
                table: "intakes",
                column: "fk_programs_id");

            migrationBuilder.CreateIndex(
                name: "idx_intake_status",
                table: "intakes",
                column: "intake_status");

            migrationBuilder.CreateIndex(
                name: "fk_invoices_facilities",
                table: "invoices",
                column: "fk_facilities_id");

            migrationBuilder.CreateIndex(
                name: "idx_invoice_status",
                table: "invoices",
                column: "invoice_status");

            migrationBuilder.CreateIndex(
                name: "fk_locations_procedures_idx",
                table: "locations",
                column: "fk_procedures_id");

            migrationBuilder.CreateIndex(
                name: "idx_location_type",
                table: "locations",
                column: "location_type");

            migrationBuilder.CreateIndex(
                name: "idx_location_name",
                table: "locations",
                columns: new[] { "location_name", "location_description" });

            migrationBuilder.CreateIndex(
                name: "idx_location_description",
                table: "locations",
                columns: new[] { "location_description", "location_name", "location_type" });

            migrationBuilder.CreateIndex(
                name: "fk_medications_prescriptions_idx",
                table: "medications",
                column: "fk_prescriptions_id");

            migrationBuilder.CreateIndex(
                name: "idx_medication_name",
                table: "medications",
                column: "medication_name");

            migrationBuilder.CreateIndex(
                name: "idx_medication_type",
                table: "medications",
                column: "medication_type");

            migrationBuilder.CreateIndex(
                name: "idx_medication_description",
                table: "medications",
                columns: new[] { "medication_description", "medication_name", "medication_type" });

            migrationBuilder.CreateIndex(
                name: "fk_objectives_goals",
                table: "objectives",
                column: "fk_goals_id");

            migrationBuilder.CreateIndex(
                name: "idx_objective_title",
                table: "objectives",
                column: "objective_title");

            migrationBuilder.CreateIndex(
                name: "idx_objective_type",
                table: "objectives",
                column: "objective_type");

            migrationBuilder.CreateIndex(
                name: "idx_objective_description",
                table: "objectives",
                columns: new[] { "objective_description", "objective_title" });

            migrationBuilder.CreateIndex(
                name: "fk_papers_clients_idx",
                table: "papers",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_papers_contractors",
                table: "papers",
                column: "fk_contractors_id");

            migrationBuilder.CreateIndex(
                name: "idx_paper_identifier",
                table: "papers",
                column: "paper_identifier");

            migrationBuilder.CreateIndex(
                name: "idx_paper_status",
                table: "papers",
                column: "paper_status");

            migrationBuilder.CreateIndex(
                name: "idx_paper_description",
                table: "papers",
                columns: new[] { "paper_description", "paper_title", "paper_identifier" });

            migrationBuilder.CreateIndex(
                name: "idx_paper_title",
                table: "papers",
                columns: new[] { "paper_title", "paper_identifier", "paper_description" });

            migrationBuilder.CreateIndex(
                name: "idx_age",
                table: "persons",
                column: "age");

            migrationBuilder.CreateIndex(
                name: "idx_email",
                table: "persons",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "idx_ethnicity",
                table: "persons",
                column: "ethnicity");

            migrationBuilder.CreateIndex(
                name: "idx_first_name",
                table: "persons",
                column: "first_name");

            migrationBuilder.CreateIndex(
                name: "idx_gender",
                table: "persons",
                column: "gender");

            migrationBuilder.CreateIndex(
                name: "idx_language",
                table: "persons",
                column: "language");

            migrationBuilder.CreateIndex(
                name: "idx_last_name",
                table: "persons",
                column: "last_name");

            migrationBuilder.CreateIndex(
                name: "idx_middle_name",
                table: "persons",
                column: "middle_name");

            migrationBuilder.CreateIndex(
                name: "idx_religion",
                table: "persons",
                column: "religion");

            migrationBuilder.CreateIndex(
                name: "idx_social_sec_number",
                table: "persons",
                column: "social_sec_number");

            migrationBuilder.CreateIndex(
                name: "idx_name",
                table: "persons",
                columns: new[] { "first_name", "last_name", "middle_name" });

            migrationBuilder.CreateIndex(
                name: "fk_phone_numbers_persons",
                table: "phone_numbers",
                column: "fk_persons_id");

            migrationBuilder.CreateIndex(
                name: "idx_phone_number",
                table: "phone_numbers",
                column: "phone_number");

            migrationBuilder.CreateIndex(
                name: "idx_phone_type",
                table: "phone_numbers",
                column: "phone_type");

            migrationBuilder.CreateIndex(
                name: "fk_policies_clients_idx",
                table: "policies",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "policy_name",
                table: "policies",
                column: "policy_name");

            migrationBuilder.CreateIndex(
                name: "policy_number",
                table: "policies",
                column: "policy_number");

            migrationBuilder.CreateIndex(
                name: "fk_prescriptions_clients_idx",
                table: "prescriptions",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "idx_prescription_identifier",
                table: "prescriptions",
                column: "prescription_identifier");

            migrationBuilder.CreateIndex(
                name: "fk_procedures_authorizations",
                table: "procedures",
                column: "fk_authorizations_id");

            migrationBuilder.CreateIndex(
                name: "fk_procedures_claims",
                table: "procedures",
                column: "fk_claims_id");

            migrationBuilder.CreateIndex(
                name: "idx_procedure_name",
                table: "procedures",
                column: "procedure_name");

            migrationBuilder.CreateIndex(
                name: "idx_procedure_description",
                table: "procedures",
                columns: new[] { "procedure_description", "procedure_name" });

            migrationBuilder.CreateIndex(
                name: "fk_programs_behaviors",
                table: "programs",
                column: "fk_behaviors_id");

            migrationBuilder.CreateIndex(
                name: "fk_programs_clients_idx",
                table: "programs",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_programs_goals",
                table: "programs",
                column: "fk_goals_id");

            migrationBuilder.CreateIndex(
                name: "fk_programs_remedies_idx",
                table: "programs",
                column: "fk_remedies_id");

            migrationBuilder.CreateIndex(
                name: "idx_program_description",
                table: "programs",
                columns: new[] { "program_description", "program_name" });

            migrationBuilder.CreateIndex(
                name: "idx_program_name",
                table: "programs",
                columns: new[] { "program_name", "program_description" });

            migrationBuilder.CreateIndex(
                name: "fk_providers_contractors",
                table: "providers",
                column: "fk_contractors_id");

            migrationBuilder.CreateIndex(
                name: "idx_provider_company",
                table: "providers",
                column: "provider_company");

            migrationBuilder.CreateIndex(
                name: "idx_provider_ein",
                table: "providers",
                column: "provider_ein");

            migrationBuilder.CreateIndex(
                name: "idx_provider_identifier",
                table: "providers",
                column: "provider_identifier");

            migrationBuilder.CreateIndex(
                name: "idx_provider_number",
                table: "providers",
                column: "provider_number");

            migrationBuilder.CreateIndex(
                name: "idx_provider_type",
                table: "providers",
                column: "provider_type");

            migrationBuilder.CreateIndex(
                name: "fk_relationships_clients_idx",
                table: "relationships",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_relationships_persons",
                table: "relationships",
                column: "fk_persons_id");

            migrationBuilder.CreateIndex(
                name: "idx_relationship_type",
                table: "relationships",
                column: "relationship_type");

            migrationBuilder.CreateIndex(
                name: "fk_remedies_clients_idx",
                table: "remedies",
                column: "fk_clients_id");

            migrationBuilder.CreateIndex(
                name: "fk_remedies_programs",
                table: "remedies",
                column: "fk_programs_id");

            migrationBuilder.CreateIndex(
                name: "idx_remedy_description",
                table: "remedies",
                columns: new[] { "remedy_description", "remedy_name" });

            migrationBuilder.CreateIndex(
                name: "idx_remedy_name",
                table: "remedies",
                columns: new[] { "remedy_name", "remedy_description" });

            migrationBuilder.CreateIndex(
                name: "fk_supervisions_comments",
                table: "supervisions",
                column: "fk_comments_id");

            migrationBuilder.CreateIndex(
                name: "fk_supervisions_providers",
                table: "supervisions",
                column: "fk_providers_id");

            migrationBuilder.CreateIndex(
                name: "idx_supervision_mode",
                table: "supervisions",
                column: "supervision_mode");

            migrationBuilder.CreateIndex(
                name: "idx_supervision_type",
                table: "supervisions",
                column: "supervision_type");

            migrationBuilder.CreateIndex(
                name: "idx_supervision_characteristic",
                table: "supervisions",
                columns: new[] { "supervision_characteristic", "supervision_type" });

            migrationBuilder.CreateIndex(
                name: "fk_tasks_comments",
                table: "tasks",
                column: "fk_comments_id");

            migrationBuilder.CreateIndex(
                name: "fk_tasks_users_idx",
                table: "tasks",
                column: "fk_users_id");

            migrationBuilder.CreateIndex(
                name: "idx_scheduled_by",
                table: "tasks",
                column: "scheduled_by");

            migrationBuilder.CreateIndex(
                name: "idx_task_status",
                table: "tasks",
                column: "task_status");

            migrationBuilder.CreateIndex(
                name: "idx_task_type",
                table: "tasks",
                column: "task_type");

            migrationBuilder.CreateIndex(
                name: "idx_task_regarding",
                table: "tasks",
                columns: new[] { "task_regarding", "task_type" });

            migrationBuilder.CreateIndex(
                name: "fk_trials_behaviors",
                table: "trials",
                column: "fk_behaviors_id");

            migrationBuilder.CreateIndex(
                name: "fk_users_comments",
                table: "users",
                column: "fk_comments_id");

            migrationBuilder.CreateIndex(
                name: "fk_users_contractors",
                table: "users",
                column: "fk_contractors_id");

            migrationBuilder.CreateIndex(
                name: "idx_username",
                table: "users",
                column: "username");

            migrationBuilder.AddForeignKey(
                name: "fk_goals_programs",
                table: "goals",
                column: "fk_programs_id",
                principalTable: "programs",
                principalColumn: "programs_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_goals_behaviors",
                table: "goals",
                column: "fk_behaviors_id",
                principalTable: "behaviors",
                principalColumn: "behaviors_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_programs_behaviors",
                table: "programs",
                column: "fk_behaviors_id",
                principalTable: "behaviors",
                principalColumn: "behaviors_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_programs_remedies",
                table: "programs",
                column: "fk_remedies_id",
                principalTable: "remedies",
                principalColumn: "remedies_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_appointments_comments",
                table: "appointments",
                column: "fk_comments_id",
                principalTable: "comments",
                principalColumn: "comments_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_appointments_supervisions",
                table: "appointments",
                column: "fk_supervisions_id",
                principalTable: "supervisions",
                principalColumn: "supervisions_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_appointments_users",
                table: "appointments",
                column: "fk_users_id",
                principalTable: "users",
                principalColumn: "users_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_supervisions_comments",
                table: "supervisions",
                column: "fk_comments_id",
                principalTable: "comments",
                principalColumn: "comments_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_tasks_comments",
                table: "tasks",
                column: "fk_comments_id",
                principalTable: "comments",
                principalColumn: "comments_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_tasks_users",
                table: "tasks",
                column: "fk_users_id",
                principalTable: "users",
                principalColumn: "users_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_users_comments",
                table: "users",
                column: "fk_comments_id",
                principalTable: "comments",
                principalColumn: "comments_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_behaviors_clients",
                table: "behaviors");

            migrationBuilder.DropForeignKey(
                name: "fk_goals_clients",
                table: "goals");

            migrationBuilder.DropForeignKey(
                name: "fk_programs_clients",
                table: "programs");

            migrationBuilder.DropForeignKey(
                name: "fk_remedies_clients",
                table: "remedies");

            migrationBuilder.DropForeignKey(
                name: "fk_users_comments",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "fk_behaviors_programs",
                table: "behaviors");

            migrationBuilder.DropForeignKey(
                name: "fk_goals_programs",
                table: "goals");

            migrationBuilder.DropForeignKey(
                name: "fk_remedies_programs",
                table: "remedies");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "assignments");

            migrationBuilder.DropTable(
                name: "codes");

            migrationBuilder.DropTable(
                name: "contractors_clients");

            migrationBuilder.DropTable(
                name: "diagnoses");

            migrationBuilder.DropTable(
                name: "e_signs");

            migrationBuilder.DropTable(
                name: "intakes");

            migrationBuilder.DropTable(
                name: "medications");

            migrationBuilder.DropTable(
                name: "objectives");

            migrationBuilder.DropTable(
                name: "papers");

            migrationBuilder.DropTable(
                name: "phone_numbers");

            migrationBuilder.DropTable(
                name: "relationships");

            migrationBuilder.DropTable(
                name: "tasks");

            migrationBuilder.DropTable(
                name: "trials");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "supervisions");

            migrationBuilder.DropTable(
                name: "prescriptions");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "procedures");

            migrationBuilder.DropTable(
                name: "providers");

            migrationBuilder.DropTable(
                name: "authorizations");

            migrationBuilder.DropTable(
                name: "claims");

            migrationBuilder.DropTable(
                name: "policies");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "facilities");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "contractors");

            migrationBuilder.DropTable(
                name: "programs");

            migrationBuilder.DropTable(
                name: "goals");

            migrationBuilder.DropTable(
                name: "remedies");

            migrationBuilder.DropTable(
                name: "behaviors");
        }
    }
}
