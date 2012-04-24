package com.tsoft.service;

import java.util.List;

import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MemberSalaryInfo;
import com.tsoft.Info.MembersInfo;

public interface MemberSalaryService {

	public List<MemberSalaryInfo> getMemberSalary(MembersInfo mi);
}
