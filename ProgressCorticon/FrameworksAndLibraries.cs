using Progress.Corticon.Foundation;
using Progress.Corticon.RuleEngine;
using Progress.Corticon.RuleEngine.Entities;
using Progress.Corticon.RuleEngine.Rules;
using Progress.Corticon.RuleEngine.Vocabulary;
using Progress.Corticon.RuleEngine.Execution;
using Progress.Corticon.RuleEngine.Validation;
using Progress.Corticon.RuleEngine.Deployment;
using Progress.Corticon.RuleEngine.Logging;
using Progress.Corticon.RuleEngine.Persistence;
using Progress.Corticon.RuleEngine.Security;
using Progress.Corticon.RuleEngine.Extensions;
using Progress.Corticon.RuleEngine.Versioning;
using Progress.Corticon.RuleEngine.Analytics;
using Progress.Corticon.RuleEngine.Integration;

namespace CorticonExamples 
{
    // Progress.Corticon.Foundation Example
    public class FoundationExample
    {
        private ICorticonRuntime runtime;

        public void Initialize()
        {
            runtime = CorticonRuntimeFactory.CreateRuntime();
        }
    }

    // Progress.Corticon.RuleEngine Example
    public class RuleEngineExample
    {
        private ICcServer server;

        public void ExecuteRules()
        {
            var decision = server.Execute("MyRuleset");
        }
    }

    // Progress.Corticon.RuleEngine.Entities Example
    public class EntityExample
    {
        private IEntity customer;

        public void CreateEntity()
        {
            customer = EntityFactory.CreateEntity("Customer");
            customer.SetValue("name", "John Doe");
        }
    }

    // Progress.Corticon.RuleEngine.Rules Example
    public class RulesExample
    {
        private IRulesheet rulesheet;

        public void LoadRules()
        {
            rulesheet = RulesheetFactory.LoadRulesheet("CustomerRules.ers");
        }
    }

    // Progress.Corticon.RuleEngine.Vocabulary Example
    public class VocabularyExample
    {
        private IVocabulary vocabulary;

        public void LoadVocabulary()
        {
            vocabulary = VocabularyFactory.LoadVocabulary("Business.ecore");
        }
    }

    // Progress.Corticon.RuleEngine.Execution Example
    public class ExecutionExample
    {
        private IExecutionContext context;

        public void ProcessRules()
        {
            var result = context.Execute();
        }
    }

    // Progress.Corticon.RuleEngine.Validation Example
    public class ValidationExample
    {
        private IValidator validator;

        public void ValidateRules()
        {
            var issues = validator.ValidateRuleset("BusinessRules");
        }
    }

    // Progress.Corticon.RuleEngine.Deployment Example
    public class DeploymentExample
    {
        private IDeploymentManager manager;

        public void DeployRules()
        {
            manager.DeployRuleset("OrderProcessing.ers");
        }
    }

    // Progress.Corticon.RuleEngine.Logging Example
    public class LoggingExample
    {
        private ILogger logger;

        public void LogRuleExecution()
        {
            logger.LogRuleTrace("Rule execution completed");
        }
    }

    // Progress.Corticon.RuleEngine.Persistence Example
    public class PersistenceExample
    {
        private IPersistenceManager persistence;

        public void SaveRuleState()
        {
            persistence.SaveState("RuleState.xml");
        }
    }

    // Progress.Corticon.RuleEngine.Security Example
    public class SecurityExample
    {
        private ISecurityManager security;

        public void SetupSecurity()
        {
            security.ApplyRulesetPermissions("OrderRules");
        }
    }

    // Progress.Corticon.RuleEngine.Extensions Example
    public class ExtensionsExample
    {
        private IExtensionManager extensions;

        public void RegisterExtension()
        {
            extensions.RegisterCustomFunction("MyCustomFunction");
        }
    }

    // Progress.Corticon.RuleEngine.Versioning Example
    public class VersioningExample
    {
        private IVersionManager versions;

        public void ManageVersions()
        {
            versions.CreateRulesetVersion("OrderRules", "2.0");
        }
    }

    // Progress.Corticon.RuleEngine.Analytics Example
    public class AnalyticsExample
    {
        private IAnalyticsEngine analytics;

        public void GatherMetrics()
        {
            var metrics = analytics.GetRuleExecutionMetrics();
        }
    }

    // Progress.Corticon.RuleEngine.Integration Example
    public class IntegrationExample
    {
        private IIntegrationService integration;

        public void ConnectExternalSystem()
        {
            integration.ConnectToDataSource("CRM");
        }
    }
}
