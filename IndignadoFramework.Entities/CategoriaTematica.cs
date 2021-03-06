//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace IndignadoFramework.Entities
{
    [Serializable]
    [DataContractAttribute(IsReference = true)]
    [KnownType(typeof(CategoriaTematicaProjection))]
    [MetadataType(typeof(CategoriaTematicaMetaData))]
    public partial class CategoriaTematica 
    {
        #region Primitive Properties
    
        [DataMemberAttribute()]
        public virtual int Id
        {
            get;
            set;
        }
    
        [DataMemberAttribute()]
        public virtual string Nombre
        {
            get;
            set;
        }
    
        [DataMemberAttribute()]
        public virtual string Descripcion
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        [DataMemberAttribute()]
        public virtual ICollection<EspecificacionUsuario> Usuarios
        {
            get
            {
                if (_usuarios == null)
                {
                    var newCollection = new FixupCollection<EspecificacionUsuario>();
                    newCollection.CollectionChanged += FixupUsuarios;
                    _usuarios = newCollection;
                }
                return _usuarios;
            }
            set
            {
                if (!ReferenceEquals(_usuarios, value))
                {
                    var previousValue = _usuarios as FixupCollection<EspecificacionUsuario>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupUsuarios;
                    }
                    _usuarios = value;
                    var newValue = value as FixupCollection<EspecificacionUsuario>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupUsuarios;
                    }
                }
            }
        }
        private ICollection<EspecificacionUsuario> _usuarios;
    
        [DataMemberAttribute()]
        public virtual ICollection<Convocatoria> Convocatorias
        {
            get
            {
                if (_convocatorias == null)
                {
                    var newCollection = new FixupCollection<Convocatoria>();
                    newCollection.CollectionChanged += FixupConvocatorias;
                    _convocatorias = newCollection;
                }
                return _convocatorias;
            }
            set
            {
                if (!ReferenceEquals(_convocatorias, value))
                {
                    var previousValue = _convocatorias as FixupCollection<Convocatoria>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupConvocatorias;
                    }
                    _convocatorias = value;
                    var newValue = value as FixupCollection<Convocatoria>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupConvocatorias;
                    }
                }
            }
        }
        private ICollection<Convocatoria> _convocatorias;
    
        [DataMemberAttribute()]
        public virtual ICollection<Contenido> Contenidos
        {
            get
            {
                if (_contenidos == null)
                {
                    var newCollection = new FixupCollection<Contenido>();
                    newCollection.CollectionChanged += FixupContenidos;
                    _contenidos = newCollection;
                }
                return _contenidos;
            }
            set
            {
                if (!ReferenceEquals(_contenidos, value))
                {
                    var previousValue = _contenidos as FixupCollection<Contenido>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupContenidos;
                    }
                    _contenidos = value;
                    var newValue = value as FixupCollection<Contenido>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupContenidos;
                    }
                }
            }
        }
        private ICollection<Contenido> _contenidos;

        #endregion
        #region Association Fixup
    
        private void FixupUsuarios(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (EspecificacionUsuario item in e.NewItems)
                {
                    if (!item.CategoriasTematicas.Contains(this))
                    {
                        item.CategoriasTematicas.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (EspecificacionUsuario item in e.OldItems)
                {
                    if (item.CategoriasTematicas.Contains(this))
                    {
                        item.CategoriasTematicas.Remove(this);
                    }
                }
            }
        }
    
        private void FixupConvocatorias(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Convocatoria item in e.NewItems)
                {
                    item.CategoriaTematica = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Convocatoria item in e.OldItems)
                {
                    if (ReferenceEquals(item.CategoriaTematica, this))
                    {
                        item.CategoriaTematica = null;
                    }
                }
            }
        }
    
        private void FixupContenidos(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Contenido item in e.NewItems)
                {
                    item.CategoriaTematica = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Contenido item in e.OldItems)
                {
                    if (ReferenceEquals(item.CategoriaTematica, this))
                    {
                        item.CategoriaTematica = null;
                    }
                }
            }
        }

        #endregion
    }
}
