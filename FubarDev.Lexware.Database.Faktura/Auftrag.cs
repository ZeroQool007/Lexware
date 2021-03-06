﻿// <copyright file="Auftrag.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

using FubarDev.Lexware.Database.Shared;

using NodaTime;

namespace FubarDev.Lexware.Database.Faktura
{
    /// <summary>
    /// Rechnung, die ggf. aus einem Abo-Vorgang erstellt wurde
    /// </summary>
    public class Auftrag : IAuditEntity, IZeroAsNullEntity
    {
        /// <summary>
        /// SheetNr
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// AuftragsNr
        /// </summary>
        public virtual string AuftragsNr { get; set; }

        /// <summary>
        /// AuftragsKennung
        /// </summary>
        public virtual int Auftragskennung { get; set; }

        /// <summary>
        /// KundenNr
        /// </summary>
        public virtual string KundenNr { get; set; }

        /// <summary>
        /// Anschrift_Anrede, Anschrift_Firma, Anschrift_Ort, Anschrift_FirmaPlz, Anschrift_Email
        /// </summary>
        public virtual Adresse Anschrift { get; set; }

        /// <summary>
        /// Summen_netto_haupt
        /// </summary>
        public virtual decimal SummenNettoHaupt { get; set; }

        /// <summary>
        /// Summen_brutto_haupt
        /// </summary>
        public virtual decimal SummenBruttoHaupt { get; set; }

        /// <summary>
        /// Summen_netto_neben
        /// </summary>
        public virtual decimal SummenNettoNeben { get; set; }

        /// <summary>
        /// Summen_brutto_neben
        /// </summary>
        public virtual decimal SummenBruttoNeben { get; set; }

        /// <summary>
        /// Summen_ust_gesamt
        /// </summary>
        public virtual decimal SummenUmsatzsteuerGesamt { get; set; }

        /// <summary>
        /// Summen_abschlag_netto
        /// </summary>
        public virtual decimal SummenAbschlagNetto { get; set; }

        /// <summary>
        /// Summen_abschlag_brutto
        /// </summary>
        public virtual decimal SummenAbschlagBrutto { get; set; }

        /// <summary>
        /// Summen_abschlag_ust
        /// </summary>
        public virtual decimal SummenAbschlagUmsatzsteuer { get; set; }

        /// <summary>
        /// Summen_abschlag_forderung
        /// </summary>
        public virtual decimal SummenAbschlagForderung { get; set; }

        /// <summary>
        /// Summen_abschlag_erhalten
        /// </summary>
        public virtual decimal SummenAbschlagErhalten { get; set; }

        /// <summary>
        /// Summen_gesamt
        /// </summary>
        public virtual decimal SummenGesamt { get; set; }

        /// <summary>
        /// Holt oder setzt die Status-Kennzeichen
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// Holt oder setzt den Auftrag, der von diesem Auftrag weitergeführt wird
        /// </summary>
        /// <remarks>
        /// Der Auftrag, auf den verwiesen wird, wird durch diesen Auftrag ersetzt.
        /// </remarks>
        public virtual Auftrag WeiterAus { get; set; }

        /// <summary>
        /// Holt oder setzt den Auftrag, der diesen Auftrag weiterführt
        /// </summary>
        /// <remarks>
        /// Der Auftrag, auf den verwiesen wird, ersetzt diesen Auftrag.
        /// </remarks>
        public virtual Auftrag WeiterIn { get; set; }

        /// <summary>
        /// lAboVorlageID
        /// </summary>
        public virtual AboVorlage AboVorlage { get; set; }

        /// <summary>
        /// tsAboBegin
        /// </summary>
        public virtual LocalDate? AboBeginn { get; set; }

        /// <summary>
        /// tsAboEnde
        /// </summary>
        public virtual LocalDate? AboEnde { get; set; }

        /// <summary>
        /// fAboAbgeschlossen
        /// </summary>
        public virtual bool AboAbgeschlossen { get; set; }

        /// <summary>
        /// Konditionen_PreisgrpNr
        /// </summary>
        public virtual Preisgruppe KonditionenPreisgruppe { get; set; }

        /// <summary>
        /// Konditionen_Rabatt
        /// </summary>
        public virtual decimal KonditionenRabatt { get; set; }

        /// <summary>
        /// Konditionen_Rabatt_Proz
        /// </summary>
        public virtual decimal KonditionenRabattProzent { get; set; }

        /// <summary>
        /// tsLieferTermin
        /// </summary>
        public virtual LocalDate? Liefertermin { get; set; }

        /// <summary>
        /// System_created
        /// </summary>
        public virtual DateTime? Created { get; set; }

        /// <summary>
        /// System_created_user
        /// </summary>
        public virtual string CreatedBy { get; set; }

        /// <summary>
        /// System_updated
        /// </summary>
        public virtual DateTime? Updated { get; set; }

        /// <summary>
        /// System_updated_user
        /// </summary>
        public virtual string UpdatedBy { get; set; }

        /// <summary>
        /// Positionen
        /// </summary>
        public virtual IList<AuftragPos> Positionen { get; set; }
    }
}
