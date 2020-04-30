using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace healthTekv2.Models
{
    public partial class healthtekContext : DbContext
    {
        public healthtekContext()
        {
        }

        public healthtekContext(DbContextOptions<healthtekContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Assignments> Assignments { get; set; }
        public virtual DbSet<Authorizations> Authorizations { get; set; }
        public virtual DbSet<Behaviors> Behaviors { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Codes> Codes { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Contractors> Contractors { get; set; }
        public virtual DbSet<ContractorsClients> ContractorsClients { get; set; }
        public virtual DbSet<Diagnoses> Diagnoses { get; set; }
        public virtual DbSet<ESigns> ESigns { get; set; }
        public virtual DbSet<Facilities> Facilities { get; set; }
        public virtual DbSet<Goals> Goals { get; set; }
        public virtual DbSet<Intakes> Intakes { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Medications> Medications { get; set; }
        public virtual DbSet<Objectives> Objectives { get; set; }
        public virtual DbSet<Papers> Papers { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<PhoneNumbers> PhoneNumbers { get; set; }
        public virtual DbSet<Policies> Policies { get; set; }
        public virtual DbSet<Prescriptions> Prescriptions { get; set; }
        public virtual DbSet<Procedures> Procedures { get; set; }
        public virtual DbSet<Programs> Programs { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Relationships> Relationships { get; set; }
        public virtual DbSet<Remedies> Remedies { get; set; }
        public virtual DbSet<Supervisions> Supervisions { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Trials> Trials { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=12345678!;database=healthtek", x => x.ServerVersion("8.0.17-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.ToTable("addresses");

                entity.HasIndex(e => e.City)
                    .HasName("idx_city");

                entity.HasIndex(e => e.FkFacilitiesId)
                    .HasName("fk_addresses_facilities_idx");

                entity.HasIndex(e => e.FkPersonsId)
                    .HasName("fk_addresses_persons_idx");

                entity.HasIndex(e => e.State)
                    .HasName("idx_state");

                entity.HasIndex(e => new { e.Country, e.Region })
                    .HasName("idx_country");

                entity.HasIndex(e => new { e.Address1, e.Address2, e.Region })
                    .HasName("idx_address");

                entity.Property(e => e.AddressesId)
                    .HasColumnName("addresses_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AddressCreatedTs)
                    .HasColumnName("address_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.AddressModifiedTs)
                    .HasColumnName("address_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkFacilitiesId)
                    .HasColumnName("fk_facilities_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkPersonsId)
                    .HasColumnName("fk_persons_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GpsCoordinates)
                    .HasColumnName("gps_coordinates")
                    .HasColumnType("decimal(10,8)");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkFacilities)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.FkFacilitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_addresses_facilities");

                entity.HasOne(d => d.FkPersons)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.FkPersonsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_addresses_persons");
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.ToTable("appointments");

                entity.HasIndex(e => e.AppointmentStatus)
                    .HasName("idx_appointment_status");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_appointments_clients_idx");

                entity.HasIndex(e => e.FkCommentsId)
                    .HasName("fk_appointments_comments_idx");

                entity.HasIndex(e => e.FkContractorsId)
                    .HasName("fk_appointments_contractors_idx");

                entity.HasIndex(e => e.FkFacilitiesId)
                    .HasName("fk_appointments_facilities_idx");

                entity.HasIndex(e => e.FkLocationsId)
                    .HasName("fk_appointments_locations_idx");

                entity.HasIndex(e => e.FkProceduresId)
                    .HasName("fk_appointments_procedures_idx");

                entity.HasIndex(e => e.FkSupervisionsId)
                    .HasName("fk_appointments_supervisions_idx");

                entity.HasIndex(e => e.FkUsersId)
                    .HasName("fk_appointments_users_idx");

                entity.Property(e => e.AppointmentsId)
                    .HasColumnName("appointments_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppointmentAttachment).HasColumnName("appointment_attachment");

                entity.Property(e => e.AppointmentCreatedTs)
                    .HasColumnName("appointment_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("appointment_date")
                    .HasColumnType("date");

                entity.Property(e => e.AppointmentEndTime)
                    .HasColumnName("appointment_end_time")
                    .HasColumnType("time");

                entity.Property(e => e.AppointmentModifiedTs)
                    .HasColumnName("appointment_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.AppointmentStartTime)
                    .HasColumnName("appointment_start_time")
                    .HasColumnType("time");

                entity.Property(e => e.AppointmentStatus)
                    .IsRequired()
                    .HasColumnName("appointment_status")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkCommentsId)
                    .HasColumnName("fk_comments_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkContractorsId)
                    .HasColumnName("fk_contractors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFacilitiesId)
                    .HasColumnName("fk_facilities_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkLocationsId)
                    .HasColumnName("fk_locations_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProceduresId)
                    .HasColumnName("fk_procedures_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkSupervisionsId)
                    .HasColumnName("fk_supervisions_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkUsersId)
                    .HasColumnName("fk_users_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_clients");

                entity.HasOne(d => d.FkComments)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkCommentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_comments");

                entity.HasOne(d => d.FkContractors)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkContractorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_contractors");

                entity.HasOne(d => d.FkFacilities)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkFacilitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_facilities");

                entity.HasOne(d => d.FkLocations)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkLocationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_locations");

                entity.HasOne(d => d.FkProcedures)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkProceduresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_procedures");

                entity.HasOne(d => d.FkSupervisions)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkSupervisionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_supervisions");

                entity.HasOne(d => d.FkUsers)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.FkUsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_appointments_users");
            });

            modelBuilder.Entity<Assignments>(entity =>
            {
                entity.ToTable("assignments");

                entity.HasIndex(e => e.AssignmentPosition)
                    .HasName("idx_assignment_position");

                entity.HasIndex(e => e.AssignmentStatus)
                    .HasName("idx_assignment_status");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_assignments_clients_idx");

                entity.HasIndex(e => e.FkContractorsId)
                    .HasName("fk_assignments_contractors_idx");

                entity.HasIndex(e => e.FkFacilitiesId)
                    .HasName("fk_assignments_facilities_idx");

                entity.Property(e => e.AssignmentsId)
                    .HasColumnName("assignments_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssignmentCounter)
                    .HasColumnName("assignment_counter")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.AssignmentCreatedTs)
                    .HasColumnName("assignment_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.AssignmentEffDate)
                    .HasColumnName("assignment_eff_date")
                    .HasColumnType("date");

                entity.Property(e => e.AssignmentExpDate)
                    .HasColumnName("assignment_exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.AssignmentModifiedTs)
                    .HasColumnName("assignment_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.AssignmentPosition)
                    .HasColumnName("assignment_position")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("assignment_status")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkContractorsId)
                    .HasColumnName("fk_contractors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFacilitiesId)
                    .HasColumnName("fk_facilities_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_assignments_clients");

                entity.HasOne(d => d.FkContractors)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.FkContractorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_assignments_contractors");

                entity.HasOne(d => d.FkFacilities)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.FkFacilitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_assignments_facilities");
            });

            modelBuilder.Entity<Authorizations>(entity =>
            {
                entity.ToTable("authorizations");

                entity.HasIndex(e => e.AuthorizationCode)
                    .HasName("idx_authorization_code");

                entity.HasIndex(e => e.AuthorizationNumber)
                    .HasName("idx_authorization_number");

                entity.HasIndex(e => e.AuthorizationStatus)
                    .HasName("idx_authorization_status");

                entity.HasIndex(e => e.AuthorizationType)
                    .HasName("idx_authorization_type");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_authorizations_clients_idx");

                entity.HasIndex(e => e.FkFacilitiesId)
                    .HasName("fk_authorizations_facilities_idx");

                entity.HasIndex(e => e.FkPoliciesId)
                    .HasName("fk_authorizations_policies_idx");

                entity.Property(e => e.AuthorizationsId)
                    .HasColumnName("authorizations_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AuthorizationCode)
                    .IsRequired()
                    .HasColumnName("authorization_code")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AuthorizationCreatedTs)
                    .HasColumnName("authorization_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.AuthorizationEffDate)
                    .HasColumnName("authorization_eff_date")
                    .HasColumnType("date");

                entity.Property(e => e.AuthorizationExpDate)
                    .HasColumnName("authorization_exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.AuthorizationModifiedTs)
                    .HasColumnName("authorization_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.AuthorizationNumber)
                    .HasColumnName("authorization_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AuthorizationStatus)
                    .HasColumnName("authorization_status")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AuthorizationType)
                    .HasColumnName("authorization_type")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFacilitiesId)
                    .HasColumnName("fk_facilities_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkPoliciesId)
                    .HasColumnName("fk_policies_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnitAmount)
                    .HasColumnName("unit_amount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnitsUsed)
                    .HasColumnName("units_used")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_authorizations_clients");

                entity.HasOne(d => d.FkFacilities)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.FkFacilitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_authorizations_facilities");

                entity.HasOne(d => d.FkPolicies)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.FkPoliciesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_authorizations_policies");
            });

            modelBuilder.Entity<Behaviors>(entity =>
            {
                entity.ToTable("behaviors");

                entity.HasComment("maladaptive or replacement behaviors");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_behaviors_clients_idx");

                entity.HasIndex(e => e.FkProgramsId)
                    .HasName("fk_behaviors_programs_idx");

                entity.HasIndex(e => new { e.BehaviorDescription, e.BehaviorName })
                    .HasName("idx_behavior_description");

                entity.HasIndex(e => new { e.BehaviorName, e.BehaviorDescription })
                    .HasName("idx_behavior_name");

                entity.Property(e => e.BehaviorsId)
                    .HasColumnName("behaviors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Baseline)
                    .HasColumnName("baseline")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.BehaviorCreatedTs)
                    .HasColumnName("behavior_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.BehaviorDate)
                    .HasColumnName("behavior_date")
                    .HasColumnType("date");

                entity.Property(e => e.BehaviorDescription)
                    .HasColumnName("behavior_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BehaviorModifiedTs)
                    .HasColumnName("behavior_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.BehaviorName)
                    .IsRequired()
                    .HasColumnName("behavior_name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProgramsId)
                    .HasColumnName("fk_programs_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StoNumMonths)
                    .HasColumnName("sto_num_months")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Behaviors)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_behaviors_clients");

                entity.HasOne(d => d.FkPrograms)
                    .WithMany(p => p.Behaviors)
                    .HasForeignKey(d => d.FkProgramsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_behaviors_programs");
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.ToTable("claims");

                entity.HasIndex(e => e.CheckNumber)
                    .HasName("idx_check_number");

                entity.HasIndex(e => e.ClaimStatus)
                    .HasName("idx_claim_status");

                entity.HasIndex(e => e.DisputeReason)
                    .HasName("idx_dispute_reason");

                entity.HasIndex(e => e.FkInvoicesId)
                    .HasName("fk_claims_invoices_idx");

                entity.Property(e => e.ClaimsId)
                    .HasColumnName("claims_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CheckNumber)
                    .HasColumnName("check_number")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ClaimCreatedTs)
                    .HasColumnName("claim_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ClaimModifiedTs)
                    .HasColumnName("claim_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ClaimStatus)
                    .IsRequired()
                    .HasColumnName("claim_status")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DisputeReason)
                    .HasColumnName("dispute_reason")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkInvoicesId)
                    .HasColumnName("fk_invoices_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PaidByInsuranceDate)
                    .HasColumnName("paid_by_insurance date")
                    .HasColumnType("date");

                entity.Property(e => e.PaidToContractorDate)
                    .HasColumnName("paid_to_contractor_date")
                    .HasColumnType("date");

                entity.Property(e => e.ReconciledDate)
                    .HasColumnName("reconciled_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.FkInvoices)
                    .WithMany(p => p.Claims)
                    .HasForeignKey(d => d.FkInvoicesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_claims_invoices");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.ClientsId)
                    .HasColumnName("clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientCreatedTs)
                    .HasColumnName("client_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ClientModifiedTs)
                    .HasColumnName("client_modified_ts")
                    .HasColumnType("timestamp");
            });

            modelBuilder.Entity<Codes>(entity =>
            {
                entity.ToTable("codes");

                entity.HasIndex(e => e.CodeType)
                    .HasName("idx_code_type");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_codes_clients_idx");

                entity.HasIndex(e => e.FkProceduresId)
                    .HasName("fk_codes_procedures_idx");

                entity.HasIndex(e => new { e.CodeTitle, e.CodeDescription })
                    .HasName("idx_code_title");

                entity.HasIndex(e => new { e.CodeDescription, e.CodeTitle, e.CodeType })
                    .HasName("idx_code_description");

                entity.Property(e => e.CodesId)
                    .HasColumnName("codes_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodeCreatedTs)
                    .HasColumnName("code_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.CodeDescription)
                    .HasColumnName("code_description")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CodeEffDate)
                    .HasColumnName("code_eff_date")
                    .HasColumnType("date");

                entity.Property(e => e.CodeExpDate)
                    .HasColumnName("code_exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.CodeModifiedTs)
                    .HasColumnName("code_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.CodeRate)
                    .HasColumnName("code_rate")
                    .HasColumnType("decimal(7,2)");

                entity.Property(e => e.CodeRateType)
                    .HasColumnName("code_rate_type")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CodeTitle)
                    .HasColumnName("code_title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CodeType)
                    .IsRequired()
                    .HasColumnName("code_type")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProceduresId)
                    .HasColumnName("fk_procedures_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Codes)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_codes_clients");

                entity.HasOne(d => d.FkProcedures)
                    .WithMany(p => p.Codes)
                    .HasForeignKey(d => d.FkProceduresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_codes_procedures");
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.ToTable("comments");

                entity.HasIndex(e => e.CommentSender)
                    .HasName("idx_comment_sender");

                entity.HasIndex(e => e.CommentTitle)
                    .HasName("idx_comment_title");

                entity.HasIndex(e => e.FkUsersId)
                    .HasName("fk_comments_users_idx");

                entity.HasIndex(e => new { e.CommentMessage, e.CommentTitle })
                    .HasName("idx_comment_message");

                entity.Property(e => e.CommentsId)
                    .HasColumnName("comments_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentCreatedTs)
                    .HasColumnName("comment_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.CommentMessage)
                    .HasColumnName("comment_message")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CommentModifiedTs)
                    .HasColumnName("comment_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.CommentSender)
                    .HasColumnName("comment_sender")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CommentTitle)
                    .IsRequired()
                    .HasColumnName("comment_title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FkUsersId)
                    .HasColumnName("fk_users_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkUsers)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.FkUsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comments_users");
            });

            modelBuilder.Entity<Contractors>(entity =>
            {
                entity.ToTable("contractors");

                entity.HasIndex(e => e.AreaOfResponsibility)
                    .HasName("idx_area_of_responsibility");

                entity.HasIndex(e => e.ContractorType)
                    .HasName("idx_contractor_type");

                entity.Property(e => e.ContractorsId)
                    .HasColumnName("contractors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AreaOfResponsibility)
                    .HasColumnName("area_of_responsibility")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ContractorCreatedTs)
                    .HasColumnName("contractor_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ContractorModifiedTs)
                    .HasColumnName("contractor_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ContractorType)
                    .IsRequired()
                    .HasColumnName("contractor_type")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.HrReady)
                    .HasColumnName("hr_ready")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PayRate)
                    .HasColumnName("pay_rate")
                    .HasColumnType("decimal(7,2)");
            });

            modelBuilder.Entity<ContractorsClients>(entity =>
            {
                entity.HasKey(e => new { e.ClientsId, e.ContractorsId })
                    .HasName("PRIMARY");

                entity.ToTable("contractors_clients");

                entity.HasIndex(e => e.FkFacilitiesId)
                    .HasName("fk_contractors_clients_facilities_idx");

                entity.HasIndex(e => e.FkPersonsId)
                    .HasName("fk_contractors_clients_persons_idx");

                entity.Property(e => e.ClientsId)
                    .HasColumnName("clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContractorsId)
                    .HasColumnName("contractors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFacilitiesId)
                    .HasColumnName("fk_facilities_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkPersonsId)
                    .HasColumnName("fk_persons_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkFacilities)
                    .WithMany(p => p.ContractorsClients)
                    .HasForeignKey(d => d.FkFacilitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contractors_clients_facilities");

                entity.HasOne(d => d.FkPersons)
                    .WithMany(p => p.ContractorsClients)
                    .HasForeignKey(d => d.FkPersonsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contractors_clients_persons");
            });

            modelBuilder.Entity<Diagnoses>(entity =>
            {
                entity.ToTable("diagnoses");

                entity.Property(e => e.DiagnosesId)
                    .HasColumnName("diagnoses_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiagnosisCreatedTs)
                    .HasColumnName("diagnosis_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.DiagnosisModifiedTs)
                    .HasColumnName("diagnosis_modified_ts")
                    .HasColumnType("timestamp");
            });

            modelBuilder.Entity<ESigns>(entity =>
            {
                entity.ToTable("e_signs");

                entity.HasIndex(e => e.ESignIp)
                    .HasName("idx_e_sign_ip");

                entity.HasIndex(e => e.FkPersonsId)
                    .HasName("fk_e_signs_persons_idx");

                entity.Property(e => e.ESignsId)
                    .HasColumnName("e_signs_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ESignConsent)
                    .HasColumnName("e_sign_consent")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ESignIp)
                    .HasColumnName("e_sign_ip")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ESignature).HasColumnName("e_signature");

                entity.Property(e => e.ESignsCreatedTs)
                    .HasColumnName("e_signs_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ESignsModifiedTs)
                    .HasColumnName("e_signs_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.FkPersonsId)
                    .HasColumnName("fk_persons_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.FkPersons)
                    .WithMany(p => p.ESigns)
                    .HasForeignKey(d => d.FkPersonsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_e_signs_persons");
            });

            modelBuilder.Entity<Facilities>(entity =>
            {
                entity.ToTable("facilities");

                entity.HasIndex(e => e.MedicalRecordNumber)
                    .HasName("idx_medical_record_number");

                entity.HasIndex(e => e.Supervisor)
                    .HasName("idx_supervisor");

                entity.HasIndex(e => new { e.ReferredBy, e.ReferredIdentifier })
                    .HasName("idx_referred_by");

                entity.Property(e => e.FacilitiesId)
                    .HasColumnName("facilities_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateOfArrival)
                    .HasColumnName("date_of_arrival")
                    .HasColumnType("date");

                entity.Property(e => e.FacilityCreatedTs)
                    .HasColumnName("facility_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.FacilityModifiedTs)
                    .HasColumnName("facility_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.MedicalRecordNumber)
                    .HasColumnName("medical_record_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReferredBy)
                    .HasColumnName("referred_by")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReferredIdentifier)
                    .HasColumnName("referred_identifier")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Goals>(entity =>
            {
                entity.ToTable("goals");

                entity.HasIndex(e => e.FkBehaviorsId)
                    .HasName("fk_goals_behaviors_idx");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_goals_clients_idx");

                entity.HasIndex(e => e.FkProgramsId)
                    .HasName("fk_goals_programs_idx");

                entity.HasIndex(e => e.GoalName)
                    .HasName("idx_goal_name");

                entity.HasIndex(e => e.GoalStatus)
                    .HasName("idx_goal_status");

                entity.HasIndex(e => e.GoalType)
                    .HasName("idx_goal_type");

                entity.HasIndex(e => new { e.GoalDescription, e.GoalName, e.GoalType })
                    .HasName("idx_goal_description");

                entity.Property(e => e.GoalsId)
                    .HasColumnName("goals_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkBehaviorsId)
                    .HasColumnName("fk_behaviors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProgramsId)
                    .HasColumnName("fk_programs_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoalCreatedTs)
                    .HasColumnName("goal_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.GoalDescription)
                    .HasColumnName("goal_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GoalModifiedTs)
                    .HasColumnName("goal_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.GoalName)
                    .HasColumnName("goal_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GoalStatus)
                    .HasColumnName("goal_status")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GoalType)
                    .IsRequired()
                    .HasColumnName("goal_type")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkBehaviors)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.FkBehaviorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_goals_behaviors");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_goals_clients");

                entity.HasOne(d => d.FkPrograms)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.FkProgramsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_goals_programs");
            });

            modelBuilder.Entity<Intakes>(entity =>
            {
                entity.ToTable("intakes");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_intakes_clients");

                entity.HasIndex(e => e.FkFacilitiesId)
                    .HasName("fk_intakes_facilities");

                entity.HasIndex(e => e.FkProgramsId)
                    .HasName("fk_intakes_programs");

                entity.HasIndex(e => e.IntakeStatus)
                    .HasName("idx_intake_status");

                entity.Property(e => e.IntakesId)
                    .HasColumnName("intakes_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFacilitiesId)
                    .HasColumnName("fk_facilities_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProgramsId)
                    .HasColumnName("fk_programs_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntakeCreatedTs)
                    .HasColumnName("intake_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.IntakeEffDate)
                    .HasColumnName("intake_eff_date")
                    .HasColumnType("date");

                entity.Property(e => e.IntakeExpDate)
                    .HasColumnName("intake_exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.IntakeModifiedTs)
                    .HasColumnName("intake_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.IntakeStatus)
                    .HasColumnName("intake_status")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Intakes)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_intakes_clients");

                entity.HasOne(d => d.FkFacilities)
                    .WithMany(p => p.Intakes)
                    .HasForeignKey(d => d.FkFacilitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_intakes_facilities");

                entity.HasOne(d => d.FkPrograms)
                    .WithMany(p => p.Intakes)
                    .HasForeignKey(d => d.FkProgramsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_intakes_programs");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.ToTable("invoices");

                entity.HasIndex(e => e.FkFacilitiesId)
                    .HasName("fk_invoices_facilities");

                entity.HasIndex(e => e.InvoiceStatus)
                    .HasName("idx_invoice_status");

                entity.Property(e => e.InvoicesId)
                    .HasColumnName("invoices_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkFacilitiesId)
                    .HasColumnName("fk_facilities_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Invoice).HasColumnName("invoice");

                entity.Property(e => e.InvoiceAmount)
                    .HasColumnName("invoice_amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.InvoiceCreatedTs)
                    .HasColumnName("invoice_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.InvoiceModifiedTs)
                    .HasColumnName("invoice_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.InvoiceStatus)
                    .HasColumnName("invoice_status")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkFacilities)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.FkFacilitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_invoices_facilities");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.ToTable("locations");

                entity.HasIndex(e => e.FkProceduresId)
                    .HasName("fk_locations_procedures_idx");

                entity.HasIndex(e => e.LocationType)
                    .HasName("idx_location_type");

                entity.HasIndex(e => new { e.LocationName, e.LocationDescription })
                    .HasName("idx_location_name");

                entity.HasIndex(e => new { e.LocationDescription, e.LocationName, e.LocationType })
                    .HasName("idx_location_description");

                entity.Property(e => e.LocationsId)
                    .HasColumnName("locations_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProceduresId)
                    .HasColumnName("fk_procedures_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LocationCreatedTs)
                    .HasColumnName("location_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.LocationDescription)
                    .HasColumnName("location_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LocationModifiedTs)
                    .HasColumnName("location_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.LocationName)
                    .HasColumnName("location_name")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LocationType)
                    .HasColumnName("location_type")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkProcedures)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.FkProceduresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_locations_procedures");
            });

            modelBuilder.Entity<Medications>(entity =>
            {
                entity.ToTable("medications");

                entity.HasIndex(e => e.FkPrescriptionsId)
                    .HasName("fk_medications_prescriptions_idx");

                entity.HasIndex(e => e.MedicationName)
                    .HasName("idx_medication_name");

                entity.HasIndex(e => e.MedicationType)
                    .HasName("idx_medication_type");

                entity.HasIndex(e => new { e.MedicationDescription, e.MedicationName, e.MedicationType })
                    .HasName("idx_medication_description");

                entity.Property(e => e.MedicationsId)
                    .HasColumnName("medications_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkPrescriptionsId)
                    .HasColumnName("fk_prescriptions_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedicationCreatedTs)
                    .HasColumnName("medication_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.MedicationDescription)
                    .HasColumnName("medication_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MedicationModifiedTs)
                    .HasColumnName("medication_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.MedicationName)
                    .HasColumnName("medication_name")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MedicationType)
                    .HasColumnName("medication_type")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkPrescriptions)
                    .WithMany(p => p.Medications)
                    .HasForeignKey(d => d.FkPrescriptionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_medications_prescriptions");
            });

            modelBuilder.Entity<Objectives>(entity =>
            {
                entity.ToTable("objectives");

                entity.HasIndex(e => e.FkGoalsId)
                    .HasName("fk_objectives_goals");

                entity.HasIndex(e => e.ObjectiveTitle)
                    .HasName("idx_objective_title");

                entity.HasIndex(e => e.ObjectiveType)
                    .HasName("idx_objective_type");

                entity.HasIndex(e => new { e.ObjectiveDescription, e.ObjectiveTitle })
                    .HasName("idx_objective_description");

                entity.Property(e => e.ObjectivesId)
                    .HasColumnName("objectives_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkGoalsId)
                    .HasColumnName("fk_goals_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ObjectiveCreatedTs)
                    .HasColumnName("objective_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ObjectiveDescription)
                    .HasColumnName("objective_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ObjectiveModifiedTs)
                    .HasColumnName("objective_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ObjectiveNumber)
                    .HasColumnName("objective_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ObjectiveStatus)
                    .HasColumnName("objective_status")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ObjectiveTitle)
                    .HasColumnName("objective_title")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ObjectiveType)
                    .HasColumnName("objective_type")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkGoals)
                    .WithMany(p => p.Objectives)
                    .HasForeignKey(d => d.FkGoalsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_objectives_goals");
            });

            modelBuilder.Entity<Papers>(entity =>
            {
                entity.ToTable("papers");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_papers_clients_idx");

                entity.HasIndex(e => e.FkContractorsId)
                    .HasName("fk_papers_contractors");

                entity.HasIndex(e => e.PaperIdentifier)
                    .HasName("idx_paper_identifier");

                entity.HasIndex(e => e.PaperStatus)
                    .HasName("idx_paper_status");

                entity.HasIndex(e => new { e.PaperDescription, e.PaperTitle, e.PaperIdentifier })
                    .HasName("idx_paper_description");

                entity.HasIndex(e => new { e.PaperTitle, e.PaperIdentifier, e.PaperDescription })
                    .HasName("idx_paper_title");

                entity.Property(e => e.PapersId)
                    .HasColumnName("papers_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DigitalPaper)
                    .IsRequired()
                    .HasColumnName("digital_paper");

                entity.Property(e => e.ExpWarningNumDays)
                    .HasColumnName("exp_warning_num_days")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkContractorsId)
                    .HasColumnName("fk_contractors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsSorted)
                    .HasColumnName("is_sorted")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.PaperCreatedTs)
                    .HasColumnName("paper_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PaperDescription)
                    .HasColumnName("paper_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaperEffDate)
                    .HasColumnName("paper_eff_date")
                    .HasColumnType("date");

                entity.Property(e => e.PaperExpDate)
                    .HasColumnName("paper_exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.PaperIdentifier)
                    .HasColumnName("paper_identifier")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaperModifiedTs)
                    .HasColumnName("paper_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PaperStatus)
                    .HasColumnName("paper_status")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaperTitle)
                    .IsRequired()
                    .HasColumnName("paper_title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.RequiredItem)
                    .HasColumnName("required_item")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.UploadDate)
                    .HasColumnName("upload_date")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Papers)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_papers_clients");

                entity.HasOne(d => d.FkContractors)
                    .WithMany(p => p.Papers)
                    .HasForeignKey(d => d.FkContractorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_papers_contractors");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.ToTable("persons");

                entity.HasIndex(e => e.Age)
                    .HasName("idx_age");

                entity.HasIndex(e => e.Email)
                    .HasName("idx_email");

                entity.HasIndex(e => e.Ethnicity)
                    .HasName("idx_ethnicity");

                entity.HasIndex(e => e.FirstName)
                    .HasName("idx_first_name");

                entity.HasIndex(e => e.Gender)
                    .HasName("idx_gender");

                entity.HasIndex(e => e.Language)
                    .HasName("idx_language");

                entity.HasIndex(e => e.LastName)
                    .HasName("idx_last_name");

                entity.HasIndex(e => e.MiddleName)
                    .HasName("idx_middle_name");

                entity.HasIndex(e => e.Religion)
                    .HasName("idx_religion");

                entity.HasIndex(e => e.SocialSecNumber)
                    .HasName("idx_social_sec_number");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.MiddleName })
                    .HasName("idx_name");

                entity.Property(e => e.PersonsId)
                    .HasColumnName("persons_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Ethnicity)
                    .HasColumnName("ethnicity")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PersonCreatedTs)
                    .HasColumnName("person_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PersonModifiedTs)
                    .HasColumnName("person_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Religion)
                    .HasColumnName("religion")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SocialSecNumber)
                    .HasColumnName("social_sec_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PhoneNumbers>(entity =>
            {
                entity.ToTable("phone_numbers");

                entity.HasIndex(e => e.FkPersonsId)
                    .HasName("fk_phone_numbers_persons");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("idx_phone_number");

                entity.HasIndex(e => e.PhoneType)
                    .HasName("idx_phone_type");

                entity.Property(e => e.PhoneNumbersId)
                    .HasColumnName("phone_numbers_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkPersonsId)
                    .HasColumnName("fk_persons_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PhoneNumberCreatedTs)
                    .HasColumnName("phone_number_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PhoneNumberModifiedTs)
                    .HasColumnName("phone_number_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PhoneType)
                    .HasColumnName("phone_type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkPersons)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.FkPersonsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_phone_numbers_persons");
            });

            modelBuilder.Entity<Policies>(entity =>
            {
                entity.ToTable("policies");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_policies_clients_idx");

                entity.HasIndex(e => e.PolicyName)
                    .HasName("policy_name");

                entity.HasIndex(e => e.PolicyNumber)
                    .HasName("policy_number");

                entity.Property(e => e.PoliciesId)
                    .HasColumnName("policies_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PolicyCreatedTs)
                    .HasColumnName("policy_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PolicyEffDate)
                    .HasColumnName("policy_eff_date")
                    .HasColumnType("date");

                entity.Property(e => e.PolicyExpDate)
                    .HasColumnName("policy_exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.PolicyModifiedTs)
                    .HasColumnName("policy_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PolicyName)
                    .HasColumnName("policy_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("policy_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Policies)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_policies_clients");
            });

            modelBuilder.Entity<Prescriptions>(entity =>
            {
                entity.ToTable("prescriptions");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_prescriptions_clients_idx");

                entity.HasIndex(e => e.PrescriptionIdentifier)
                    .HasName("idx_prescription_identifier");

                entity.Property(e => e.PrescriptionsId)
                    .HasColumnName("prescriptions_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrescriptionCreatedTs)
                    .HasColumnName("prescription_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.PrescriptionDosage)
                    .HasColumnName("prescription_dosage")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PrescriptionDuration)
                    .HasColumnName("prescription_duration")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PrescriptionFrequency)
                    .HasColumnName("prescription_frequency")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PrescriptionIdentifier)
                    .HasColumnName("prescription_identifier")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PrescriptionModifiedTs)
                    .HasColumnName("prescription_modified_ts")
                    .HasColumnType("timestamp");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_prescriptions_clients");
            });

            modelBuilder.Entity<Procedures>(entity =>
            {
                entity.ToTable("procedures");

                entity.HasComment("replacing entity services");

                entity.HasIndex(e => e.FkAuthorizationsId)
                    .HasName("fk_procedures_authorizations");

                entity.HasIndex(e => e.FkClaimsId)
                    .HasName("fk_procedures_claims");

                entity.HasIndex(e => e.ProcedureName)
                    .HasName("idx_procedure_name");

                entity.HasIndex(e => new { e.ProcedureDescription, e.ProcedureName })
                    .HasName("idx_procedure_description");

                entity.Property(e => e.ProceduresId)
                    .HasColumnName("procedures_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientDailyLimit)
                    .HasColumnName("client_daily_limit")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ContractorDailyLimit)
                    .HasColumnName("contractor_daily_limit")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FkAuthorizationsId)
                    .HasColumnName("fk_authorizations_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClaimsId)
                    .HasColumnName("fk_claims_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PremiumAmount)
                    .HasColumnName("premium_amount")
                    .HasColumnType("decimal(8,2)");

                entity.Property(e => e.ProcedureCreatedTs)
                    .HasColumnName("procedure_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ProcedureDescription)
                    .HasColumnName("procedure_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProcedureModifiedTs)
                    .HasColumnName("procedure_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ProcedureName)
                    .HasColumnName("procedure_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProcedureUnits)
                    .HasColumnName("procedure_units")
                    .HasColumnType("smallint(6)");

                entity.HasOne(d => d.FkAuthorizations)
                    .WithMany(p => p.Procedures)
                    .HasForeignKey(d => d.FkAuthorizationsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_procedures_authorizations");

                entity.HasOne(d => d.FkClaims)
                    .WithMany(p => p.Procedures)
                    .HasForeignKey(d => d.FkClaimsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_procedures_claims");
            });

            modelBuilder.Entity<Programs>(entity =>
            {
                entity.ToTable("programs");

                entity.HasIndex(e => e.FkBehaviorsId)
                    .HasName("fk_programs_behaviors");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_programs_clients_idx");

                entity.HasIndex(e => e.FkGoalsId)
                    .HasName("fk_programs_goals");

                entity.HasIndex(e => e.FkRemediesId)
                    .HasName("fk_programs_remedies_idx");

                entity.HasIndex(e => new { e.ProgramDescription, e.ProgramName })
                    .HasName("idx_program_description");

                entity.HasIndex(e => new { e.ProgramName, e.ProgramDescription })
                    .HasName("idx_program_name");

                entity.Property(e => e.ProgramsId)
                    .HasColumnName("programs_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkBehaviorsId)
                    .HasColumnName("fk_behaviors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkGoalsId)
                    .HasColumnName("fk_goals_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkRemediesId)
                    .HasColumnName("fk_remedies_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgramCreatedTs)
                    .HasColumnName("program_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ProgramDescription)
                    .HasColumnName("program_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProgramEffDate)
                    .HasColumnName("program_eff_date")
                    .HasColumnType("date");

                entity.Property(e => e.ProgramExpDate)
                    .HasColumnName("program_exp_date")
                    .HasColumnType("date");

                entity.Property(e => e.ProgramModifiedTs)
                    .HasColumnName("program_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ProgramName)
                    .HasColumnName("program_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkBehaviors)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.FkBehaviorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_programs_behaviors");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_programs_clients");

                entity.HasOne(d => d.FkGoals)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.FkGoalsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_programs_goals");

                entity.HasOne(d => d.FkRemedies)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.FkRemediesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_programs_remedies");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.ToTable("providers");

                entity.HasIndex(e => e.FkContractorsId)
                    .HasName("fk_providers_contractors");

                entity.HasIndex(e => e.ProviderCompany)
                    .HasName("idx_provider_company");

                entity.HasIndex(e => e.ProviderEin)
                    .HasName("idx_provider_ein");

                entity.HasIndex(e => e.ProviderIdentifier)
                    .HasName("idx_provider_identifier");

                entity.HasIndex(e => e.ProviderNumber)
                    .HasName("idx_provider_number");

                entity.HasIndex(e => e.ProviderType)
                    .HasName("idx_provider_type");

                entity.Property(e => e.ProvidersId)
                    .HasColumnName("providers_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkContractorsId)
                    .HasColumnName("fk_contractors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProviderCompany)
                    .HasColumnName("provider_company")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProviderCreatedTs)
                    .HasColumnName("provider_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ProviderEin)
                    .HasColumnName("provider_ein")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProviderIdentifier)
                    .HasColumnName("provider_identifier")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProviderModifiedTs)
                    .HasColumnName("provider_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.ProviderNumber)
                    .HasColumnName("provider_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProviderType)
                    .HasColumnName("provider_type")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ProviderUrl)
                    .HasColumnName("provider_url")
                    .HasColumnType("varchar(2083)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkContractors)
                    .WithMany(p => p.Providers)
                    .HasForeignKey(d => d.FkContractorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_providers_contractors");
            });

            modelBuilder.Entity<Relationships>(entity =>
            {
                entity.ToTable("relationships");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_relationships_clients_idx");

                entity.HasIndex(e => e.FkPersonsId)
                    .HasName("fk_relationships_persons");

                entity.HasIndex(e => e.RelationshipType)
                    .HasName("idx_relationship_type");

                entity.Property(e => e.RelationshipsId)
                    .HasColumnName("relationships_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkPersonsId)
                    .HasColumnName("fk_persons_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RelationshipCreatedTs)
                    .HasColumnName("relationship_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.RelationshipModifiedTs)
                    .HasColumnName("relationship_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.RelationshipType)
                    .HasColumnName("relationship_type")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_relationships_clients");

                entity.HasOne(d => d.FkPersons)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.FkPersonsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_relationships_persons");
            });

            modelBuilder.Entity<Remedies>(entity =>
            {
                entity.ToTable("remedies");

                entity.HasComment("replacing interventions and reinforcers tables");

                entity.HasIndex(e => e.FkClientsId)
                    .HasName("fk_remedies_clients_idx");

                entity.HasIndex(e => e.FkProgramsId)
                    .HasName("fk_remedies_programs");

                entity.HasIndex(e => new { e.RemedyDescription, e.RemedyName })
                    .HasName("idx_remedy_description");

                entity.HasIndex(e => new { e.RemedyName, e.RemedyDescription })
                    .HasName("idx_remedy_name");

                entity.Property(e => e.RemediesId)
                    .HasColumnName("remedies_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkClientsId)
                    .HasColumnName("fk_clients_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProgramsId)
                    .HasColumnName("fk_programs_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RemedyCreatedTs)
                    .HasColumnName("remedy_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.RemedyDescription)
                    .HasColumnName("remedy_description")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.RemedyModifiedTs)
                    .HasColumnName("remedy_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.RemedyName)
                    .HasColumnName("remedy_name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkClients)
                    .WithMany(p => p.Remedies)
                    .HasForeignKey(d => d.FkClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_remedies_clients");

                entity.HasOne(d => d.FkPrograms)
                    .WithMany(p => p.Remedies)
                    .HasForeignKey(d => d.FkProgramsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_remedies_programs");
            });

            modelBuilder.Entity<Supervisions>(entity =>
            {
                entity.ToTable("supervisions");

                entity.HasIndex(e => e.FkCommentsId)
                    .HasName("fk_supervisions_comments");

                entity.HasIndex(e => e.FkProvidersId)
                    .HasName("fk_supervisions_providers");

                entity.HasIndex(e => e.SupervisionMode)
                    .HasName("idx_supervision_mode");

                entity.HasIndex(e => e.SupervisionType)
                    .HasName("idx_supervision_type");

                entity.HasIndex(e => new { e.SupervisionCharacteristic, e.SupervisionType })
                    .HasName("idx_supervision_characteristic");

                entity.Property(e => e.SupervisionsId)
                    .HasColumnName("supervisions_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientPresent)
                    .HasColumnName("client_present")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.FkCommentsId)
                    .HasColumnName("fk_comments_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkProvidersId)
                    .HasColumnName("fk_providers_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SupervisionCharacteristic)
                    .HasColumnName("supervision_characteristic")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SupervisionCreatedTs)
                    .HasColumnName("supervision_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.SupervisionDate)
                    .HasColumnName("supervision_date")
                    .HasColumnType("date");

                entity.Property(e => e.SupervisionMode)
                    .HasColumnName("supervision_mode")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SupervisionModifiedTs)
                    .HasColumnName("supervision_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.SupervisionType)
                    .HasColumnName("supervision_type")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkComments)
                    .WithMany(p => p.Supervisions)
                    .HasForeignKey(d => d.FkCommentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supervisions_comments");

                entity.HasOne(d => d.FkProviders)
                    .WithMany(p => p.Supervisions)
                    .HasForeignKey(d => d.FkProvidersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_supervisions_providers");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks");

                entity.HasIndex(e => e.FkCommentsId)
                    .HasName("fk_tasks_comments");

                entity.HasIndex(e => e.FkUsersId)
                    .HasName("fk_tasks_users_idx");

                entity.HasIndex(e => e.ScheduledBy)
                    .HasName("idx_scheduled_by");

                entity.HasIndex(e => e.TaskStatus)
                    .HasName("idx_task_status");

                entity.HasIndex(e => e.TaskType)
                    .HasName("idx_task_type");

                entity.HasIndex(e => new { e.TaskRegarding, e.TaskType })
                    .HasName("idx_task_regarding");

                entity.Property(e => e.TasksId)
                    .HasColumnName("tasks_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DueDate)
                    .HasColumnName("due_date")
                    .HasColumnType("date");

                entity.Property(e => e.FkCommentsId)
                    .HasColumnName("fk_comments_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkUsersId)
                    .HasColumnName("fk_users_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCleared)
                    .HasColumnName("is_cleared")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.ScheduledBy)
                    .IsRequired()
                    .HasColumnName("scheduled_by")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TaskAttachment).HasColumnName("task_attachment");

                entity.Property(e => e.TaskCreatedTs)
                    .HasColumnName("task_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.TaskModifiedTs)
                    .HasColumnName("task_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.TaskRegarding)
                    .HasColumnName("task_regarding")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TaskStatus)
                    .HasColumnName("task_status")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TaskType)
                    .HasColumnName("task_type")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkComments)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.FkCommentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tasks_comments");

                entity.HasOne(d => d.FkUsers)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.FkUsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tasks_users");
            });

            modelBuilder.Entity<Trials>(entity =>
            {
                entity.ToTable("trials");

                entity.HasIndex(e => e.FkBehaviorsId)
                    .HasName("fk_trials_behaviors");

                entity.Property(e => e.TrialsId)
                    .HasColumnName("trials_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkBehaviorsId)
                    .HasColumnName("fk_behaviors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SuccessfulTrials)
                    .HasColumnName("successful_trials")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.TotalTrials)
                    .HasColumnName("total_trials")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.TrialCreatedTs)
                    .HasColumnName("trial_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.TrialModifiedTs)
                    .HasColumnName("trial_modified_ts")
                    .HasColumnType("timestamp");

                entity.HasOne(d => d.FkBehaviors)
                    .WithMany(p => p.Trials)
                    .HasForeignKey(d => d.FkBehaviorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_trials_behaviors");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.FkCommentsId)
                    .HasName("fk_users_comments");

                entity.HasIndex(e => e.FkContractorsId)
                    .HasName("fk_users_contractors");

                entity.HasIndex(e => e.Username)
                    .HasName("idx_username");

                entity.Property(e => e.UsersId)
                    .HasColumnName("users_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkCommentsId)
                    .HasColumnName("fk_comments_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FkContractorsId)
                    .HasColumnName("fk_contractors_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PasswordConfirm)
                    .IsRequired()
                    .HasColumnName("password_confirm")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserCreatedTs)
                    .HasColumnName("user_created_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.UserModifiedTs)
                    .HasColumnName("user_modified_ts")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.FkComments)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkCommentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_comments");

                entity.HasOne(d => d.FkContractors)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkContractorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_users_contractors");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
