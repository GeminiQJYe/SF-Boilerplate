﻿ 
namespace SF.Core.Entitys.Abstraction
{
    using System;

#if !NET20

    /// <summary>
    /// Represents an entity that has an unique identifier, created, updated, deleted metadata and version info, 
    /// using a long for the <see cref="IHaveVersion{T}.Version"/>.
    /// </summary>
    /// <typeparam name="TIdentity">The identifier type</typeparam>
    /// <typeparam name="TCreatedBy">The created by type</typeparam>
    /// <typeparam name="TUpdatedBy">The updated by type</typeparam>
    public abstract class EntityWithCreatedAndUpdatedMetaAndVersionAsLong<TIdentity, TCreatedBy, TUpdatedBy>
        : EntityWithTypedId<TIdentity>, IHaveCreatedMeta<TCreatedBy>, IHaveUpdatedMeta<TUpdatedBy>, IHaveVersionAsLong
    {
        private DateTimeOffset _createdOn;
        private DateTimeOffset _updatedOn;

        #region Implementation of IHaveCreatedMeta<TCreatedBy>

        /// <summary>
        /// The <see cref="DateTimeOffset"/> when it was created
        /// </summary>
        public virtual DateTimeOffset CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }

        /// <summary>
        /// The identifier (or entity) which first created this entity
        /// </summary>
        public virtual TCreatedBy CreatedBy { get; set; }

        #endregion

        #region Implementation of IHaveUpdatedMeta<TUpdatedBy>

        /// <summary>
        /// The <see cref="DateTimeOffset"/> when it was last updated
        /// </summary>
        public virtual DateTimeOffset UpdatedOn
        {
            get { return _updatedOn; }
            set { _updatedOn = value; }
        }

        /// <summary>
        /// The identifier (or entity) which last updated this entity
        /// </summary>
        public virtual TUpdatedBy UpdatedBy { get; set; }

        #endregion

        #region Implementation of IHaveVersionAsLong

        /// <summary>
        /// The entity version
        /// </summary>
        public virtual long Version { get; set; }

        #endregion

        /// <summary>
        /// Creates a new instance and sets the <see cref="CreatedOn"/> and 
        /// <see cref="UpdatedOn"/> to <see cref="DateTimeOffset.Now"/>
        /// </summary>
        protected EntityWithCreatedAndUpdatedMetaAndVersionAsLong()
        {
            _createdOn = _updatedOn = DateTimeOffset.Now;
        }

        /// <summary>
        /// Creates a new instance and sets the <see cref="CreatedOn"/> and 
        /// <see cref="UpdatedOn"/> to <see cref="DateTimeOffset.Now"/>
        /// </summary>
        /// <param name="id">The entity id</param>
        protected EntityWithCreatedAndUpdatedMetaAndVersionAsLong(TIdentity id)
            : base(id)
        {
            _createdOn = _updatedOn = DateTimeOffset.Now;
        }
    }

    /// <summary>
    /// Represents an entity that has an unique identifier, created, updated metadata and version info, 
    /// using a long for the <see cref="IHaveVersion{T}.Version"/>.
    /// </summary>
    /// <typeparam name="TIdentity">The identifier type</typeparam>
    /// <typeparam name="TCreatedAndUpdated">The created and updated by type</typeparam>
    public abstract class EntityWithCreatedAndUpdatedMetaAndVersionAsLong<TIdentity, TCreatedAndUpdated>
        : EntityWithCreatedAndUpdatedMetaAndVersionAsLong<TIdentity, TCreatedAndUpdated, TCreatedAndUpdated>
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        protected EntityWithCreatedAndUpdatedMetaAndVersionAsLong()
        {
            
        }

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="id">The entity id</param>
        protected EntityWithCreatedAndUpdatedMetaAndVersionAsLong(TIdentity id)
            : base(id)
        {
            
        }
    }

    /// <summary>
    /// Represents an entity that has an unique identifier, created, updated, deleted metadata and version info, 
    /// using a long for the <see cref="IHaveVersion{T}.Version"/> and a <see cref="string"/> as an 
    /// identifier for the <see cref="IHaveCreatedMeta{T}.CreatedBy"/> and
    /// <see cref="IHaveUpdatedMeta{T}.UpdatedBy"/>
    /// </summary>
    /// <typeparam name="TIdentity">The identifier type</typeparam>
    public abstract class EntityWithCreatedAndUpdatedMetaAndVersionAsLong<TIdentity>
        : EntityWithCreatedAndUpdatedMetaAndVersionAsLong<TIdentity, string, string>, IHaveCreatedMeta, IHaveUpdatedMeta
    {
        /// <summary>
        /// Creates a new instance
        /// </summary>
        protected EntityWithCreatedAndUpdatedMetaAndVersionAsLong()
        {

        }

        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="id">The entity id</param>
        protected EntityWithCreatedAndUpdatedMetaAndVersionAsLong(TIdentity id)
            : base(id)
        {

        }
    }

#endif
}
