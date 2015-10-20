

class CriticalSection
{
public:
	CriticalSectoin()
	{
		EnterCriticalSection();
	}

	~CriticalSectoin()
	{

	}
};

void Func()
{
	CriticalSectoin s;
	/// 작업 
	// s.BraBraBra....
}