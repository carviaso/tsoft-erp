package com.tsoft.service.impl;

import java.util.List;

import com.tsoft.Info.MemberSalaryInfo;
import com.tsoft.Info.MembersInfo;
import com.tsoft.dao.MemberSalaryDao;
import com.tsoft.service.MemberSalaryService;

public class MemberSalaryServiceImpl implements MemberSalaryService {
	private MemberSalaryDao memberSalaryDao;

	public MemberSalaryDao getMemberSalaryDao() {
		return memberSalaryDao;
	}

	public void setMemberSalaryDao(MemberSalaryDao memberSalaryDao) {
		this.memberSalaryDao = memberSalaryDao;
	}

	@Override
	public List<MemberSalaryInfo> getMemberSalary(MembersInfo mi) {
		 
		return memberSalaryDao.getMemberSalary(mi);
	}

}
