using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����״̬
/// </summary>
public class RoleStateIdle : RoleStateAbstract
{
    /// <summary>
    /// ���캯��
    /// </summary>
    /// <param name="roleFSMMgr">����״̬������</param>
    public RoleStateIdle(RoleFSMMgr roleFSMMgr) : base(roleFSMMgr)
    {
    }

    /// <summary>
    /// ʵ�ֻ��� ����״̬
    /// </summary>
    public override void OnEnter()
    {
        base.OnEnter();

        CurrRoleFSMMgr.CurrRoleCtrl.Animator.SetBool(ToAnimatorCondition.ToIdleFight.ToString(), true);
    }

    /// <summary>
    /// ʵ�ֻ��� ִ��״̬
    /// </summary>
    public override void OnUpdate()
    {
        base.OnUpdate();

        CurrRoleAnimatorStateInfo = CurrRoleFSMMgr.CurrRoleCtrl.Animator.GetCurrentAnimatorStateInfo(0);
        if (CurrRoleAnimatorStateInfo.IsName(RoleAnimatorName.Idle_Fight.ToString()))
        {
            CurrRoleFSMMgr.CurrRoleCtrl.Animator.SetInteger(ToAnimatorCondition.CurrState.ToString(), (int)RoleState.Idle);
        }
    }

    /// <summary>
    /// ʵ�ֻ��� �뿪״̬
    /// </summary>
    public override void OnLeave()
    {
        base.OnLeave();

        CurrRoleFSMMgr.CurrRoleCtrl.Animator.SetBool(ToAnimatorCondition.ToIdleFight.ToString(), false);
    }
}