//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DisciplinaTurma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DisciplinaTurma()
        {
            this.TurmaHora = new HashSet<TurmaHora>();
            this.Aluno = new HashSet<Aluno>();
        }
    
        public int SEQ_DISCIPLINA_TURMA { get; set; }
        public Nullable<int> CODIGO_DISCIPLINA { get; set; }
        public string CODIGO_TURMA { get; set; }
        public Nullable<int> CODIGO_SEMESTRE { get; set; }
    
        public virtual Disciplina Disciplina { get; set; }
        public virtual Turma Turma { get; set; }
        public virtual Semestre Semestre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TurmaHora> TurmaHora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aluno> Aluno { get; set; }
    }
}
