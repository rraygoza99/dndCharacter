﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SL.API.Migrations
{
    [DbContext(typeof(DndCharacterManagerContext))]
    [Migration("20181117015028_id_race_feat")]
    partial class id_race_feat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Model.Entities.AbilityScore", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnName("id_character");

                    b.Property<int>("IdCAbilityScore")
                        .HasColumnName("id_c_ability_score");

                    b.Property<int>("AbilityModifier")
                        .HasColumnName("ability_modifier");

                    b.Property<bool>("Proficient")
                        .HasColumnName("proficient");

                    b.Property<int>("Value")
                        .HasColumnName("value");

                    b.HasKey("IdCharacter", "IdCAbilityScore");

                    b.HasIndex("IdCAbilityScore");

                    b.ToTable("ability_score");
                });

            modelBuilder.Entity("DAL.Model.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_character")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmorClass")
                        .HasColumnName("armor_class");

                    b.Property<int>("CopperCoins")
                        .HasColumnName("copper_coins");

                    b.Property<int>("ElectrumCoins")
                        .HasColumnName("electrum_coins");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnName("experience_points");

                    b.Property<int>("GoldCoins")
                        .HasColumnName("gold_coins");

                    b.Property<int>("IdCAligment")
                        .HasColumnName("id_c_aligment");

                    b.Property<int>("IdClass")
                        .HasColumnName("id_class");

                    b.Property<int>("IdRace")
                        .HasColumnName("id_race");

                    b.Property<int>("Initiative")
                        .HasColumnName("initiative");

                    b.Property<string>("Level")
                        .HasColumnName("level");

                    b.Property<int>("MaxHitPoints")
                        .HasColumnName("max_hit_points");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("PlayerName")
                        .HasColumnName("player_name");

                    b.Property<int>("ProficiencyBonus")
                        .HasColumnName("proficiency_bonus");

                    b.Property<int>("SilverCoins")
                        .HasColumnName("silver_coins");

                    b.Property<int>("Speed")
                        .HasColumnName("speed");

                    b.HasKey("Id");

                    b.HasIndex("IdCAligment");

                    b.HasIndex("IdClass");

                    b.HasIndex("IdRace");

                    b.ToTable("character");
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterEquipment", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnName("id_character");

                    b.Property<int>("IdEquipment")
                        .HasColumnName("id_equipment");

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity");

                    b.HasKey("IdCharacter", "IdEquipment");

                    b.HasIndex("IdEquipment");

                    b.ToTable("character_equipment");
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterFeat", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnName("id_character");

                    b.Property<int>("IdFeat")
                        .HasColumnName("id_feat");

                    b.HasKey("IdCharacter", "IdFeat");

                    b.HasIndex("IdFeat");

                    b.ToTable("character_feat");
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterSkill", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnName("id_character");

                    b.Property<int>("IdSkill")
                        .HasColumnName("id_skill");

                    b.Property<bool>("Proficient")
                        .HasColumnName("proficient");

                    b.Property<int>("Value")
                        .HasColumnName("value");

                    b.HasKey("IdCharacter", "IdSkill");

                    b.HasIndex("IdSkill");

                    b.ToTable("character_skill");
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterSpell", b =>
                {
                    b.Property<int>("IdCharacter")
                        .HasColumnName("id_character");

                    b.Property<int>("IdSpell")
                        .HasColumnName("id_spell");

                    b.HasKey("IdCharacter", "IdSpell");

                    b.HasIndex("IdSpell");

                    b.ToTable("character_spell");
                });

            modelBuilder.Entity("DAL.Model.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_class")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("class");
                });

            modelBuilder.Entity("DAL.Model.Entities.Collection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_collection")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("collection");
                });

            modelBuilder.Entity("DAL.Model.Entities.DataCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_data_collection")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCollection")
                        .HasColumnName("id_collection");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("IdCollection");

                    b.ToTable("data_collection");
                });

            modelBuilder.Entity("DAL.Model.Entities.Equipment", b =>
                {
                    b.Property<int>("IdEquipment")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_equipment")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cost")
                        .HasColumnName("cost");

                    b.Property<int>("IdCTypeEquipment")
                        .HasColumnName("id_c_type_equipment");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("IdEquipment");

                    b.HasIndex("IdCTypeEquipment");

                    b.ToTable("equipment");
                });

            modelBuilder.Entity("DAL.Model.Entities.Feat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_feat")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<int?>("IdRace")
                        .HasColumnName("id_race");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Prereqisite")
                        .HasColumnName("prerequisite");

                    b.HasKey("Id");

                    b.HasIndex("IdRace");

                    b.ToTable("feat");
                });

            modelBuilder.Entity("DAL.Model.Entities.FeatFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_feat_feature")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddedAmount")
                        .HasColumnName("added_amount");

                    b.Property<int>("IdCTypeFeat")
                        .HasColumnName("id_c_type_feat");

                    b.Property<int>("IdFeat")
                        .HasColumnName("id_feat");

                    b.HasKey("Id");

                    b.HasIndex("IdCTypeFeat");

                    b.HasIndex("IdFeat");

                    b.ToTable("feat_feature");
                });

            modelBuilder.Entity("DAL.Model.Entities.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_race")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnName("age");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Size")
                        .HasColumnName("size");

                    b.HasKey("Id");

                    b.ToTable("race");
                });

            modelBuilder.Entity("DAL.Model.Entities.Skill", b =>
                {
                    b.Property<int>("IdSkill")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_skill")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCAbilityScore")
                        .HasColumnName("id_c_ability_score");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("IdSkill");

                    b.HasIndex("IdCAbilityScore");

                    b.ToTable("skill");
                });

            modelBuilder.Entity("DAL.Model.Entities.Spell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_spell")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description");

                    b.Property<int>("Level")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("spell");
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellClass", b =>
                {
                    b.Property<int>("IdSpell")
                        .HasColumnName("id_spell");

                    b.Property<int>("IdClass")
                        .HasColumnName("id_c_class");

                    b.HasKey("IdSpell", "IdClass");

                    b.HasIndex("IdClass");

                    b.ToTable("spell_class");
                });

            modelBuilder.Entity("DAL.Model.Entities.AbilityScore", b =>
                {
                    b.HasOne("DAL.Model.Entities.DataCollection", "AbilityScoreCollection")
                        .WithMany("AbilityScores")
                        .HasForeignKey("IdCAbilityScore")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Character", "Character")
                        .WithMany("AbilityScores")
                        .HasForeignKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.Character", b =>
                {
                    b.HasOne("DAL.Model.Entities.DataCollection", "Aligment")
                        .WithMany("CharactersAligment")
                        .HasForeignKey("IdCAligment")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Class", "Class")
                        .WithMany("CharacterClasses")
                        .HasForeignKey("IdClass")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Race", "Race")
                        .WithMany("CharacterRace")
                        .HasForeignKey("IdRace")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterEquipment", b =>
                {
                    b.HasOne("DAL.Model.Entities.Character", "Character")
                        .WithMany("CharacterEquipments")
                        .HasForeignKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Equipment", "Equipment")
                        .WithMany("CharacterEquipments")
                        .HasForeignKey("IdEquipment")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterFeat", b =>
                {
                    b.HasOne("DAL.Model.Entities.Character", "Character")
                        .WithMany("CharacterFeats")
                        .HasForeignKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Feat", "Feat")
                        .WithMany("CharacterFeats")
                        .HasForeignKey("IdFeat")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterSkill", b =>
                {
                    b.HasOne("DAL.Model.Entities.Character", "Character")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Skill", "Skill")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("IdSkill")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.CharacterSpell", b =>
                {
                    b.HasOne("DAL.Model.Entities.Character", "Character")
                        .WithMany("CharacterSpells")
                        .HasForeignKey("IdCharacter")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Spell", "Spell")
                        .WithMany("CharacterSpells")
                        .HasForeignKey("IdSpell")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.DataCollection", b =>
                {
                    b.HasOne("DAL.Model.Entities.Collection", "Collection")
                        .WithMany("DataCollections")
                        .HasForeignKey("IdCollection")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.Equipment", b =>
                {
                    b.HasOne("DAL.Model.Entities.DataCollection", "TypeEquipment")
                        .WithMany("TypesEquipment")
                        .HasForeignKey("IdCTypeEquipment")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.Feat", b =>
                {
                    b.HasOne("DAL.Model.Entities.Race", "Race")
                        .WithMany("FeatsRace")
                        .HasForeignKey("IdRace");
                });

            modelBuilder.Entity("DAL.Model.Entities.FeatFeature", b =>
                {
                    b.HasOne("DAL.Model.Entities.DataCollection", "TypeFeat")
                        .WithMany("FeatFeatures")
                        .HasForeignKey("IdCTypeFeat")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Feat", "Feat")
                        .WithMany("FeatFeatures")
                        .HasForeignKey("IdFeat")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.Skill", b =>
                {
                    b.HasOne("DAL.Model.Entities.DataCollection", "AbilityScoreSkill")
                        .WithMany("AbilitiesScoreSkill")
                        .HasForeignKey("IdCAbilityScore")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Entities.SpellClass", b =>
                {
                    b.HasOne("DAL.Model.Entities.Class", "Class")
                        .WithMany("SpellClasses")
                        .HasForeignKey("IdClass")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Entities.Spell", "Spell")
                        .WithMany("SpellClasses")
                        .HasForeignKey("IdSpell")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
