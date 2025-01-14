﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using DBRecipes.FactoryClasses;
using DBRecipes.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DBRecipes.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitCategoryEntityInfo();
			InitIngredientEntityInfo();
			InitInstructionEntityInfo();
			InitRecipeEntityInfo();
			InitRecipeCategoryEntityInfo();
			InitUserEntityInfo();
			InitVersionInfoEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits CategoryEntity's info objects</summary>
		private void InitCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoryFieldIndex), "CategoryEntity");
			this.AddElementFieldInfo("CategoryEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)CategoryFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("CategoryEntity", "Name", typeof(System.String), true, false, false, false,  (int)CategoryFieldIndex.Name, 100, 0, 0);
		}

		/// <summary>Inits IngredientEntity's info objects</summary>
		private void InitIngredientEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(IngredientFieldIndex), "IngredientEntity");
			this.AddElementFieldInfo("IngredientEntity", "Component", typeof(System.String), true, false, false, false,  (int)IngredientFieldIndex.Component, 1000, 0, 0);
			this.AddElementFieldInfo("IngredientEntity", "RecipeId", typeof(System.Int32), true, true, false, false,  (int)IngredientFieldIndex.RecipeId, 0, 0, 10);
		}

		/// <summary>Inits InstructionEntity's info objects</summary>
		private void InitInstructionEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(InstructionFieldIndex), "InstructionEntity");
			this.AddElementFieldInfo("InstructionEntity", "RecipeId", typeof(System.Int32), true, true, false, false,  (int)InstructionFieldIndex.RecipeId, 0, 0, 10);
			this.AddElementFieldInfo("InstructionEntity", "Step", typeof(System.String), true, false, false, false,  (int)InstructionFieldIndex.Step, 1000, 0, 0);
		}

		/// <summary>Inits RecipeEntity's info objects</summary>
		private void InitRecipeEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RecipeFieldIndex), "RecipeEntity");
			this.AddElementFieldInfo("RecipeEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)RecipeFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("RecipeEntity", "IsActive", typeof(System.Boolean), false, false, false, false,  (int)RecipeFieldIndex.IsActive, 0, 0, 0);
			this.AddElementFieldInfo("RecipeEntity", "Title", typeof(System.String), false, false, false, false,  (int)RecipeFieldIndex.Title, 100, 0, 0);
		}

		/// <summary>Inits RecipeCategoryEntity's info objects</summary>
		private void InitRecipeCategoryEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RecipeCategoryFieldIndex), "RecipeCategoryEntity");
			this.AddElementFieldInfo("RecipeCategoryEntity", "CategoryName", typeof(System.String), true, true, false, false,  (int)RecipeCategoryFieldIndex.CategoryName, 100, 0, 0);
			this.AddElementFieldInfo("RecipeCategoryEntity", "RecipeId", typeof(System.Int32), true, true, false, false,  (int)RecipeCategoryFieldIndex.RecipeId, 0, 0, 10);
		}

		/// <summary>Inits UserEntity's info objects</summary>
		private void InitUserEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 100, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RefreshToken", typeof(System.String), false, false, false, true,  (int)UserFieldIndex.RefreshToken, 1073741824, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), true, false, false, false,  (int)UserFieldIndex.Username, 100, 0, 0);
		}

		/// <summary>Inits VersionInfoEntity's info objects</summary>
		private void InitVersionInfoEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(VersionInfoFieldIndex), "VersionInfoEntity");
			this.AddElementFieldInfo("VersionInfoEntity", "AppliedOn", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)VersionInfoFieldIndex.AppliedOn, 0, 0, 0);
			this.AddElementFieldInfo("VersionInfoEntity", "Description", typeof(System.String), false, false, false, true,  (int)VersionInfoFieldIndex.Description, 1024, 0, 0);
			this.AddElementFieldInfo("VersionInfoEntity", "Version", typeof(System.Int64), false, false, false, false,  (int)VersionInfoFieldIndex.Version, 0, 0, 20);
		}
	}
}