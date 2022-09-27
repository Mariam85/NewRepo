﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DBFirst.HelperClasses;
using DBFirst.FactoryClasses;
using DBFirst.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DBFirst.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Ingredient'.<br/><br/></summary>
	[Serializable]
	public partial class IngredientEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private RecipeEntity _recipe;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static IngredientEntityStaticMetaData _staticMetaData = new IngredientEntityStaticMetaData();
		private static IngredientRelations _relationsFactory = new IngredientRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Recipe</summary>
			public static readonly string Recipe = "Recipe";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class IngredientEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public IngredientEntityStaticMetaData()
			{
				SetEntityCoreInfo("IngredientEntity", InheritanceHierarchyType.None, false, (int)DBFirst.EntityType.IngredientEntity, typeof(IngredientEntity), typeof(IngredientEntityFactory), false);
				AddNavigatorMetaData<IngredientEntity, RecipeEntity>("Recipe", "Ingredients", (a, b) => a._recipe = b, a => a._recipe, (a, b) => a.Recipe = b, DBFirst.RelationClasses.StaticIngredientRelations.RecipeEntityUsingRecipeIdStatic, ()=>new IngredientRelations().RecipeEntityUsingRecipeId, null, new int[] { (int)IngredientFieldIndex.RecipeId }, null, true, (int)DBFirst.EntityType.RecipeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static IngredientEntity()
		{
		}

		/// <summary> CTor</summary>
		public IngredientEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public IngredientEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this IngredientEntity</param>
		public IngredientEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="component">PK value for Ingredient which data should be fetched into this Ingredient object</param>
		/// <param name="recipeId">PK value for Ingredient which data should be fetched into this Ingredient object</param>
		public IngredientEntity(System.String component, System.Int32 recipeId) : this(component, recipeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="component">PK value for Ingredient which data should be fetched into this Ingredient object</param>
		/// <param name="recipeId">PK value for Ingredient which data should be fetched into this Ingredient object</param>
		/// <param name="validator">The custom validator object for this IngredientEntity</param>
		public IngredientEntity(System.String component, System.Int32 recipeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Component = component;
			this.RecipeId = recipeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected IngredientEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Recipe' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRecipe() { return CreateRelationInfoForNavigator("Recipe"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this IngredientEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static IngredientRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Recipe' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRecipe { get { return _staticMetaData.GetPrefetchPathElement("Recipe", CommonEntityBase.CreateEntityCollection<RecipeEntity>()); } }

		/// <summary>The Component property of the Entity Ingredient<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ingredient"."component".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 1000.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String Component
		{
			get { return (System.String)GetValue((int)IngredientFieldIndex.Component, true); }
			set	{ SetValue((int)IngredientFieldIndex.Component, value); }
		}

		/// <summary>The RecipeId property of the Entity Ingredient<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ingredient"."recipe_id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 RecipeId
		{
			get { return (System.Int32)GetValue((int)IngredientFieldIndex.RecipeId, true); }
			set	{ SetValue((int)IngredientFieldIndex.RecipeId, value); }
		}

		/// <summary>Gets / sets related entity of type 'RecipeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual RecipeEntity Recipe
		{
			get { return _recipe; }
			set { SetSingleRelatedEntityNavigator(value, "Recipe"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace DBFirst
{
	public enum IngredientFieldIndex
	{
		///<summary>Component. </summary>
		Component,
		///<summary>RecipeId. </summary>
		RecipeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace DBFirst.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Ingredient. </summary>
	public partial class IngredientRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between IngredientEntity and RecipeEntity over the m:1 relation they have, using the relation between the fields: Ingredient.RecipeId - Recipe.Id</summary>
		public virtual IEntityRelation RecipeEntityUsingRecipeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Recipe", false, new[] { RecipeFields.Id, IngredientFields.RecipeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticIngredientRelations
	{
		internal static readonly IEntityRelation RecipeEntityUsingRecipeIdStatic = new IngredientRelations().RecipeEntityUsingRecipeId;

		/// <summary>CTor</summary>
		static StaticIngredientRelations() { }
	}
}
