package com.tsoft.service.impl;

import com.tsoft.Info.MembersInfo;
import com.tsoft.dao.MembersDao;
import com.tsoft.service.MembersService;

public class MembersServiceImpl implements MembersService {
	private MembersDao membersDao;

	public MembersDao getMembersDao() {
		return membersDao;
	}

	public void setMembersDao(MembersDao membersDao) {
		this.membersDao = membersDao;
	}
	
	public MembersInfo GetMemberInfo(MembersInfo mi)
	{
		return membersDao.GetMemberInfo(mi);
	}
}
