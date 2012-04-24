package com.tsoft.service.impl;

import java.util.List;

import com.tsoft.Info.MemberAllowInfo;
import com.tsoft.Info.MembersInfo;
import com.tsoft.dao.MemberAllowDao;
import com.tsoft.service.MemberAllowService;

public class MemberAllowServiceImpl implements MemberAllowService {
	private MemberAllowDao memberAllowDao;

	public MemberAllowDao getMemberAllowDao() {
		return memberAllowDao;
	}

	public void setMemberAllowDao(MemberAllowDao memberAllowDao) {
		this.memberAllowDao = memberAllowDao;
	}

	@Override
	public List<MemberAllowInfo> getMemberAllow(MembersInfo mi) {
		 
		return memberAllowDao.getMemberAllow(mi);
	}

}
