using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



    public class processEngine
    {
    public int ParallelTaskCount { get; private set; }

    processEngine()
    {
        IntitializeConponets();
        StartProcess();
    }

    public async Task ProcessOperationAsync(XmlNode node, XmlNode root)
    {
        if (node.Attributes["name"] != null)
        {
            switch (node.Name)
            {
                case "START":
                    await GetNextTargetNodes(node, root);
                    break;
                case "SUB TASK":
                    ProcessSubTask(node, root);
                    break;
                case "PARALLEL TASK":
                    await GetNextTargetNodes(node, root);
                    break;
                case "SPLIT TASK":
                    await GetDecisionNodes(node, root);
                    break;
                case "END":
                    EndOperation();
                    break;
                case "DECISION":
                    ProcessDesision(node, root);
                    break;
                case "PARALLEL MERGE":
                    ParallelTaskCount -= 1;
                    if (ParallelTaskCount == 0)
                    {
                        await GetNextTargetNodes(node, root);
                    }
                    break;
                case "MERGE TASK":
                    await GetNextTargetNodes(node, root);
                    break;
                default:
                    break;
            }
        }
    }

    private Task GetDecisionNodes(XmlNode node, XmlNode root)
    {
        throw new NotImplementedException();
    }

    private void EndOperation()
    {
        throw new NotImplementedException();
    }

    private void ProcessDesision(XmlNode node, XmlNode root)
    {
        throw new NotImplementedException();
    }

    private Task GetDecisionNodes(XmlNode node, XmlNode root, int v, Func<XmlNode, XmlNode, Task> processOperationAsync)
    {
        throw new NotImplementedException();
    }

    private void ProcessSubTask(XmlNode node, XmlNode root)
    {
        throw new NotImplementedException();
    }

    private Task GetNextTargetNodes(XmlNode node, XmlNode root)
    {
        throw new NotImplementedException();
    }

    public static void IntitializeConponets()
    {

    }

    public static void StartProcess()
    {
        string processModelPath = GetPath("PROCESSMODEL");
        string dataModelPath = GetPath("DATAMODEL");

        XmlNode processModel = LoadDataModel(processModelPath);
        XmlNode dataModel = LoadDataModel(processModelPath);

    }

    private static void GetStartNode(Func<XmlNode, XmlNode, Task> processOperationAsync, XmlNode processModel)
    {
        throw new NotImplementedException();
    }

    private static string GetPath(string v)
    {
        throw new NotImplementedException();
    }

    private static XmlNode LoadDataModel(string path)
    {
        throw new NotImplementedException();
    }
}


public static class WorkFlow
{
    public static void IntitializeConponets()
    {
        // Initialize the UI components
    }

    public static void StartProcess()
    {
        
    }
}

