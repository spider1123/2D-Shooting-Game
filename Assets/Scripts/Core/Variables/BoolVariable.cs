#region Description

// 03-05-2021
// James LaFritz
// ----------------------------------------------------------------------------
// Based on
//
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

#endregion

using UnityEngine;

[CreateAssetMenu(fileName = "Bool", menuName = "Variable/Bool")]
public class BoolVariable : VariableBase<bool>
{
    #region Overrides of VariableBase<bool>

    /// <inheritdoc />
    public override void Add(bool amount) => variableValue = variableValue && amount;

    /// <inheritdoc />
    public override void Add(VariableBase<bool> amount) => variableValue = variableValue && amount.Value;

    #endregion


}